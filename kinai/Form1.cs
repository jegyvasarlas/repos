using System;
using System.Windows.Forms;

namespace kinai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vasarlokMegtekinteseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vasarlok vasarlok = new Vasarlok();
            vasarlok.Show();
        }

        private void rendelesLeadasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rendeles rendeles = new Rendeles();
            rendeles.Show();
        }
    }
}
