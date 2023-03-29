using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void atigazotVersenyzokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (atigazoltVersenyzok1.Visible == false) 
            {
                pictureBox1.Visible = false;
                atigazoltVersenyzok1.Visible = true;
                try
                {
                    atigazoltVersenyzok1.Megjelenit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
            else
            {
                pictureBox1.Visible = true;
                atigazoltVersenyzok1.Visible = false;
            }
                
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
