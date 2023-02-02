using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sutemeny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void faljToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Somlói galuska;300{Environment.NewLine}Rákózci túrós;280{Environment.NewLine}Csoki torta;350{Environment.NewLine}Marcipán alagút;400{Environment.NewLine}Eszterházy szelet;400", "Árlista", MessageBoxButtons.OK);
            sutemenyekToolStripMenuItem.Enabled = true;
        }

        private void sutemenyekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arlista arlista = new Arlista();
            arlista.Show();
        }
    }
}