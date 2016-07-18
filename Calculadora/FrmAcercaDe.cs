using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
        }

        private void lklEnlace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void FrmAcercaDe_Load(object sender, EventArgs e)
        {

            lklEnlaceLinkedIn.Links.Add(0, lklEnlaceLinkedIn.Text.Length, "https://www.linkedin.com/in/robertlluberes");
            lklEnlaceGitHub.Links.Add(0, lklEnlaceLinkedIn.Text.Length, "https://github.com/robertlluberes/");
        }

        private void lklCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void lklEnlaceLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void lklEnlaceGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
