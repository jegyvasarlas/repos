using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegyenOnIsMilliomos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kezdőlapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jatek1.UjJatek();
            jatek1.Visible = true;
        }

        private void ranglistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RanglistaForm rf = new RanglistaForm();
            rf.ShowDialog();
        }
    }
}
