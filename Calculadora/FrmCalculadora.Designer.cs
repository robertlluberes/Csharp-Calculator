namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.btnClearEverything = new System.Windows.Forms.Button();
            this.btnNegativoPositivo = new System.Windows.Forms.Button();
            this.btnPorciento = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lklAcercaDe = new System.Windows.Forms.LinkLabel();
            this.lklMinimizar = new System.Windows.Forms.LinkLabel();
            this.lklCerrar = new System.Windows.Forms.LinkLabel();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPantalla
            // 
            this.txtPantalla.BackColor = System.Drawing.Color.Black;
            this.txtPantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.txtPantalla.ForeColor = System.Drawing.Color.White;
            this.txtPantalla.Location = new System.Drawing.Point(0, 27);
            this.txtPantalla.MaxLength = 12;
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPantalla.Size = new System.Drawing.Size(241, 68);
            this.txtPantalla.TabIndex = 0;
            this.txtPantalla.Text = "0";
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPantalla.TextChanged += new System.EventHandler(this.txtPantalla_TextChanged);
            // 
            // btnClearEverything
            // 
            this.btnClearEverything.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearEverything.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearEverything.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEverything.Location = new System.Drawing.Point(0, 96);
            this.btnClearEverything.Name = "btnClearEverything";
            this.btnClearEverything.Size = new System.Drawing.Size(61, 53);
            this.btnClearEverything.TabIndex = 1;
            this.btnClearEverything.Text = "CE";
            this.btnClearEverything.UseVisualStyleBackColor = false;
            this.btnClearEverything.Click += new System.EventHandler(this.btnClearEverything_Click);
            // 
            // btnNegativoPositivo
            // 
            this.btnNegativoPositivo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNegativoPositivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNegativoPositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegativoPositivo.Location = new System.Drawing.Point(60, 96);
            this.btnNegativoPositivo.Name = "btnNegativoPositivo";
            this.btnNegativoPositivo.Size = new System.Drawing.Size(61, 53);
            this.btnNegativoPositivo.TabIndex = 2;
            this.btnNegativoPositivo.Text = "+/-";
            this.btnNegativoPositivo.UseVisualStyleBackColor = false;
            this.btnNegativoPositivo.Click += new System.EventHandler(this.btnNegativoPositivo_Click);
            // 
            // btnPorciento
            // 
            this.btnPorciento.BackColor = System.Drawing.SystemColors.Control;
            this.btnPorciento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorciento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorciento.Location = new System.Drawing.Point(120, 96);
            this.btnPorciento.Name = "btnPorciento";
            this.btnPorciento.Size = new System.Drawing.Size(61, 53);
            this.btnPorciento.TabIndex = 3;
            this.btnPorciento.Text = "%";
            this.btnPorciento.UseVisualStyleBackColor = false;
            this.btnPorciento.Click += new System.EventHandler(this.btnPorciento_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDivision.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnDivision.ForeColor = System.Drawing.Color.White;
            this.btnDivision.Location = new System.Drawing.Point(180, 96);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(61, 53);
            this.btnDivision.TabIndex = 4;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMultiplicacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMultiplicacion.ForeColor = System.Drawing.Color.White;
            this.btnMultiplicacion.Location = new System.Drawing.Point(180, 148);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(61, 53);
            this.btnMultiplicacion.TabIndex = 8;
            this.btnMultiplicacion.Text = "X";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.Control;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(120, 148);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(61, 53);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.Control;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(60, 148);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(61, 53);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.Control;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(0, 148);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(61, 53);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnResta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnResta.ForeColor = System.Drawing.Color.White;
            this.btnResta.Location = new System.Drawing.Point(180, 200);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(61, 53);
            this.btnResta.TabIndex = 12;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.Control;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(120, 200);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(61, 53);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.Control;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(60, 200);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(61, 53);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Control;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(0, 200);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(61, 53);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuma.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnSuma.ForeColor = System.Drawing.Color.White;
            this.btnSuma.Location = new System.Drawing.Point(180, 252);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(61, 53);
            this.btnSuma.TabIndex = 16;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Control;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(120, 252);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(61, 53);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Control;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(60, 252);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(61, 53);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Control;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(0, 252);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(61, 53);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIgual.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnIgual.ForeColor = System.Drawing.Color.White;
            this.btnIgual.Location = new System.Drawing.Point(180, 304);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(61, 53);
            this.btnIgual.TabIndex = 18;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.SystemColors.Control;
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnPunto.Location = new System.Drawing.Point(120, 304);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(61, 53);
            this.btnPunto.TabIndex = 17;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.Control;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(0, 304);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(121, 53);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "      0";
            this.btn0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBarraTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarraTitulo.Controls.Add(this.lblTitulo);
            this.pnlBarraTitulo.Controls.Add(this.lklAcercaDe);
            this.pnlBarraTitulo.Controls.Add(this.lklMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.lklCerrar);
            this.pnlBarraTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(241, 21);
            this.pnlBarraTitulo.TabIndex = 20;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            this.pnlBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseMove);
            this.pnlBarraTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseUp);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(2, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(74, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Calculadora";
            // 
            // lklAcercaDe
            // 
            this.lklAcercaDe.AutoSize = true;
            this.lklAcercaDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lklAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklAcercaDe.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklAcercaDe.LinkColor = System.Drawing.Color.White;
            this.lklAcercaDe.Location = new System.Drawing.Point(173, -2);
            this.lklAcercaDe.Name = "lklAcercaDe";
            this.lklAcercaDe.Size = new System.Drawing.Size(21, 24);
            this.lklAcercaDe.TabIndex = 2;
            this.lklAcercaDe.TabStop = true;
            this.lklAcercaDe.Text = "?";
            this.lklAcercaDe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklAcercaDe_LinkClicked);
            // 
            // lklMinimizar
            // 
            this.lklMinimizar.AutoSize = true;
            this.lklMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lklMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklMinimizar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklMinimizar.LinkColor = System.Drawing.Color.White;
            this.lklMinimizar.Location = new System.Drawing.Point(195, -3);
            this.lklMinimizar.Name = "lklMinimizar";
            this.lklMinimizar.Size = new System.Drawing.Size(21, 24);
            this.lklMinimizar.TabIndex = 1;
            this.lklMinimizar.TabStop = true;
            this.lklMinimizar.Text = "_";
            this.lklMinimizar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklMinimizar_LinkClicked);
            // 
            // lklCerrar
            // 
            this.lklCerrar.AutoSize = true;
            this.lklCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lklCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklCerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklCerrar.LinkColor = System.Drawing.Color.White;
            this.lklCerrar.Location = new System.Drawing.Point(217, -1);
            this.lklCerrar.Name = "lklCerrar";
            this.lklCerrar.Size = new System.Drawing.Size(25, 24);
            this.lklCerrar.TabIndex = 0;
            this.lklCerrar.TabStop = true;
            this.lklCerrar.Text = "X";
            this.lklCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCerrar_LinkClicked);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(241, 357);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnPorciento);
            this.Controls.Add(this.btnNegativoPositivo);
            this.Controls.Add(this.btnClearEverything);
            this.Controls.Add(this.txtPantalla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Button btnClearEverything;
        private System.Windows.Forms.Button btnNegativoPositivo;
        private System.Windows.Forms.Button btnPorciento;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.LinkLabel lklMinimizar;
        private System.Windows.Forms.LinkLabel lklCerrar;
        private System.Windows.Forms.LinkLabel lklAcercaDe;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Label lblTitulo;
    }
}

