using System;
using System.Drawing;
using System.Windows.Forms;

/*
 Realizado por Roberto Lluberes
 https://www.linkedin.com/in/robertlluberes
 https://github.com/robertlluberes
 Made with love ♥
*/

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();

            //Inicializar Mensajes de "ayuda" con el control "ToolTip".
            ttMensaje.SetToolTip(lklAcercaDe, "Acerca de...");
            ttMensaje.SetToolTip(btnClearEverything, "Limpiar todo");
        }

        #region Variables

        bool secuencia = true; //Alamacena el "estado" de cuando colocar mas numeros en el txtPantalla
        bool punto = true; //Alamacena el "estado" de cuando se puede colocar un punto decimal
        string operacion = ""; //Al macena el tipo de operacion a realizar
        double numero1; //Almacena el primer número de la operación
        double numero2; //Alamacena el segundo número luego de seleccionar la operacion a realizar
        double resultado; //Alamacena el resultado de la operacion

        bool cursorPresionado; //Almacenará el "estado" si el cursor esta "Presionado" sobre un objeto
        int ejeX; //Alamacena la posicion del cursor en el eje X
        int ejeY; //Alamacena la posicion del cursor en el eje y
        #endregion


        #region Metodos

        //Cambia de positivo a negativo los números
        private void CambiarDeSigno()
        {
            double signoNegativoPositivo;
            signoNegativoPositivo = double.Parse(txtPantalla.Text);
            signoNegativoPositivo = signoNegativoPositivo - (signoNegativoPositivo * 2);
            txtPantalla.Text = signoNegativoPositivo.ToString();
        }

        //Verifica y restringe la cantidad de caracteres en pantalla.
        private bool CantidadCaracteresPantalla()
        {

            if (txtPantalla.TextLength < txtPantalla.MaxLength)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Cambia el tamaño de la fuente en pantalla segun la cantidad de caracteres
        private void TamanoFuentePantalla()
        {
            if (txtPantalla.TextLength <= 5)
            {
                txtPantalla.Font = new Font(txtPantalla.Font.FontFamily, 45);
            }
            else if (txtPantalla.TextLength <= 8)
            {
                txtPantalla.Font = new Font(txtPantalla.Font.FontFamily, 35);
            }
            else if (txtPantalla.TextLength <= 10)
            {
                txtPantalla.Font = new Font(txtPantalla.Font.FontFamily, 25);
            }
            else if (txtPantalla.TextLength <= 20)
            {
                txtPantalla.Font = new Font(txtPantalla.Font.FontFamily, 18);
            }
        }

        //Limpia todos los valores de la operación
        private void ClearEverthing()
        {
            numero1 = 0;
            numero2 = 0;
            txtPantalla.Text = "0";
            operacion = "";
            secuencia = true;

        }

        #endregion


        #region Teclado Numerico

        private void btn1_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "1";
                secuencia = false;
                punto = true;
            }
            else if (CantidadCaracteresPantalla())
            {
                txtPantalla.Text = txtPantalla.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "2";
                secuencia = false;
                punto = true;
            }
            else if (CantidadCaracteresPantalla())
            {
                txtPantalla.Text = txtPantalla.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "3";
                secuencia = false;
                punto = true;
            }
            else if (CantidadCaracteresPantalla())
            {
                txtPantalla.Text = txtPantalla.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "4";
                secuencia = false;
                punto = true;
            }
            else if (CantidadCaracteresPantalla())
            {
                txtPantalla.Text = txtPantalla.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "5";
                secuencia = false;
                punto = true;
            }
            else if (CantidadCaracteresPantalla())
            {
                txtPantalla.Text = txtPantalla.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "6";
                secuencia = false;
                punto = true;
            }
            else if (CantidadCaracteresPantalla())
            {
                txtPantalla.Text = txtPantalla.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "7";
                secuencia = false;
                punto = true;
            }
            else if (CantidadCaracteresPantalla())
            {
                txtPantalla.Text = txtPantalla.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "8";
                secuencia = false;
                punto = true;
            }
            else if (CantidadCaracteresPantalla())
            {
                txtPantalla.Text = txtPantalla.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "9";
                secuencia = false;
                punto = true;
            }
            else if (CantidadCaracteresPantalla())
            {
                txtPantalla.Text = txtPantalla.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            if (secuencia)
            {
                txtPantalla.Text = "0";
            }
            else if (CantidadCaracteresPantalla())
            {
                txtPantalla.Text = txtPantalla.Text + "0";
            }
        }
        #endregion


        #region Teclado de Operaciones

        private void btnNegativoPositivo_Click(object sender, EventArgs e)
        {
            CambiarDeSigno();

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            secuencia = false;
            if (punto == true)
            {
                txtPantalla.Text = txtPantalla.Text + ".";
                punto = false;
            }
            else
            {
                return;
            }
        }


        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(txtPantalla.Text); //Convierte y asigna el valor que hay en la pantalla

            switch (operacion) // evalua la operacion seleccionada
            {
                case "+": //Si la operacion es suma realiza el codigo de abajao hasta el siguiente break
                    if (numero2 != 0) //Si el numero es diferente de cero
                    {
                        resultado = numero1 + numero2; //realiza la operacion y guarda el resultado en la variable "resultado"
                        txtPantalla.Text = resultado.ToString(); //Convierte el valor numero y lo presenta en pantalla
                        secuencia = true; //Habilita la secuencia
                        operacion = ""; //y limpia la operacion, lista para una nueva operacion
                    }
                    break;

                case "-":
                    if (numero2 != 0)
                    {
                        resultado = numero1 - numero2;
                        txtPantalla.Text = resultado.ToString();
                        secuencia = true;
                        operacion = "";
                    }
                    break;

                case "x":
                    if (numero2 != 0)
                    {
                        resultado = numero1 * numero2;
                        txtPantalla.Text = resultado.ToString();
                        secuencia = true;
                        operacion = "";

                    }
                    break;

                case "/":
                    try
                    {
                        resultado = numero1 / numero2;
                        txtPantalla.Text = resultado.ToString();
                        secuencia = true;
                        operacion = "";

                    }
                    catch (DivideByZeroException ex)
                    {
                        txtPantalla.Text = ex.Message; //Si se realiza una divicion entre "cero" indica un mensaje de excepcion
                    }
                    break;

            }
        }


        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numero1 = double.Parse(txtPantalla.Text);
            secuencia = true;

        }


        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            numero1 = double.Parse(txtPantalla.Text);
            secuencia = true;
        }


        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "x";
            numero1 = double.Parse(txtPantalla.Text);
            secuencia = true;
        }


        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numero1 = double.Parse(txtPantalla.Text);
            secuencia = true;
        }


        private void btnPorciento_Click(object sender, EventArgs e)
        {
            if (operacion != "") //Si hay una operacion seleccionada entonces sacamos el % del numero2
            {
                numero2 = double.Parse(txtPantalla.Text);
                numero2 = numero2 / 100;
                txtPantalla.Text = numero2.ToString();
            }
            else //De lo contrario del numero1
            {
                numero1 = double.Parse(txtPantalla.Text);
                numero1 = numero1 / 100;
                txtPantalla.Text = numero1.ToString();
            }

        }


        private void btnClearEverything_Click(object sender, EventArgs e)
        {
            ClearEverthing();
        }

        #endregion


        //Cada vez que el texto de la pantalla verificar el tamaño de la fuente.
        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {
            TamanoFuentePantalla();
        }

        #region Barra de titulo

        //LinkLabel para cerrar el formulario
        private void lklCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        //LinkLabel para minimizar el formulario
        private void lklMinimizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //LinkLabel para mortrar informacion "Acerca de..."
        private void lklAcercaDe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formulario = new FrmAcercaDe();
            formulario.ShowDialog();
        }


        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            /*
             * El evento MouseDown se produce cuando el puntero del mouse se encuentra 
             * sobre el control y se presiona un botón del mouse
             
             */
            cursorPresionado = true; //Indicamos que el cursor esta presionado en la barra de "titulo" (pnlBarraTitulo)
            ejeX = e.X; //Mientras cursor este precionado capturamos la cordenada/posicion en X 
            ejeY = e.Y; //Mientras cursor este precionado capturamos la cordenada/posicion en Y

        }

        private void pnlBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            //Si el cursor esta precionado entonces "coloca"la posicion de la barra de "titulo" (pnlBarraTitulo)
            if (cursorPresionado == true)
            {
                SetDesktopLocation(Cursor.Position.X - ejeX, Cursor.Position.Y - ejeY);
            }
        }

        private void pnlBarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            /*
             * El evento MouseUP se produce cuando el puntero del mouse 
             * se encuentra sobre el control y se suelta un botón del mouse.
             */

            //Indicamos que el cursor/mouse no esta presionado sobre la barra de "titulo" (pnlBarraTitulo)
            cursorPresionado = false;
        }


        #endregion


    }
}
