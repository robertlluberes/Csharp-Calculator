namespace Calculadora
{
    partial class FrmAcercaDe
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
            this.lklEnlaceLinkedIn = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lklCerrar = new System.Windows.Forms.LinkLabel();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCorazon = new System.Windows.Forms.Label();
            this.lklEnlaceGitHub = new System.Windows.Forms.LinkLabel();
            this.pnlBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lklEnlaceLinkedIn
            // 
            this.lklEnlaceLinkedIn.AutoSize = true;
            this.lklEnlaceLinkedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklEnlaceLinkedIn.ForeColor = System.Drawing.Color.Snow;
            this.lklEnlaceLinkedIn.LinkColor = System.Drawing.Color.White;
            this.lklEnlaceLinkedIn.Location = new System.Drawing.Point(70, 56);
            this.lklEnlaceLinkedIn.Name = "lklEnlaceLinkedIn";
            this.lklEnlaceLinkedIn.Size = new System.Drawing.Size(89, 24);
            this.lklEnlaceLinkedIn.TabIndex = 0;
            this.lklEnlaceLinkedIn.TabStop = true;
            this.lklEnlaceLinkedIn.Text = "LinkedIn";
            this.lklEnlaceLinkedIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklEnlaceLinkedIn_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(58, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Made with love ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(37, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Realizado por Roberto Lluberes";
            // 
            // lklCerrar
            // 
            this.lklCerrar.AutoSize = true;
            this.lklCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lklCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklCerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklCerrar.LinkColor = System.Drawing.Color.White;
            this.lklCerrar.Location = new System.Drawing.Point(217, -2);
            this.lklCerrar.Name = "lklCerrar";
            this.lklCerrar.Size = new System.Drawing.Size(25, 24);
            this.lklCerrar.TabIndex = 0;
            this.lklCerrar.TabStop = true;
            this.lklCerrar.Text = "X";
            this.lklCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCerrar_LinkClicked);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBarraTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarraTitulo.Controls.Add(this.lblTitulo);
            this.pnlBarraTitulo.Controls.Add(this.lklCerrar);
            this.pnlBarraTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(-2, -1);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(241, 21);
            this.pnlBarraTitulo.TabIndex = 21;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(2, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(65, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Acerca de";
            // 
            // lblCorazon
            // 
            this.lblCorazon.AutoSize = true;
            this.lblCorazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorazon.ForeColor = System.Drawing.Color.Red;
            this.lblCorazon.Location = new System.Drawing.Point(155, 110);
            this.lblCorazon.Name = "lblCorazon";
            this.lblCorazon.Size = new System.Drawing.Size(16, 17);
            this.lblCorazon.TabIndex = 22;
            this.lblCorazon.Text = "♥";
            // 
            // lklEnlaceGitHub
            // 
            this.lklEnlaceGitHub.AutoSize = true;
            this.lklEnlaceGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklEnlaceGitHub.ForeColor = System.Drawing.Color.Snow;
            this.lklEnlaceGitHub.LinkColor = System.Drawing.Color.White;
            this.lklEnlaceGitHub.Location = new System.Drawing.Point(76, 83);
            this.lklEnlaceGitHub.Name = "lklEnlaceGitHub";
            this.lklEnlaceGitHub.Size = new System.Drawing.Size(74, 24);
            this.lklEnlaceGitHub.TabIndex = 23;
            this.lklEnlaceGitHub.TabStop = true;
            this.lklEnlaceGitHub.Text = "GitHub";
            this.lklEnlaceGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklEnlaceGitHub_LinkClicked);
            // 
            // FrmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(238, 137);
            this.Controls.Add(this.lklEnlaceGitHub);
            this.Controls.Add(this.lblCorazon);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lklEnlaceLinkedIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca de";
            this.Load += new System.EventHandler(this.FrmAcercaDe_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lklEnlaceLinkedIn;
        private System.Windows.Forms.LinkLabel lklCerrar;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCorazon;
        private System.Windows.Forms.LinkLabel lklEnlaceGitHub;
    }
}