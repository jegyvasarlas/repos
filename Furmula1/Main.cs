using System;
using System.Windows.Forms;

namespace Furmula1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Átigazolt_versenyzők_Click(object sender, EventArgs e)
        {
            AtigazoltVersenyzokForm atigazolt = new AtigazoltVersenyzokForm();
            atigazolt.Show();
        }

        private void Új_versenyző_felvétele_Click(object sender, EventArgs e)
        {
            UjVersenyzoFelveteleForm ujversenyzo = new UjVersenyzoFelveteleForm();
            ujversenyzo.Show();
        }
        
        private void Kilépés_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
