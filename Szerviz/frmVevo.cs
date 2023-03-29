using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szerviz
{
    public partial class frmVevo : Form
    {
        public frmVevo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmVevoLista frmvl = new frmVevoLista();
            frmvl.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            richTextBox1.Text = "";
        }
    }
}
