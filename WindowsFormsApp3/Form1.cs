using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GombNyomas(object sender, EventArgs e)
        {
            label6.Visible = label7.Visible = true;
        }

        private void LabelNevek(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    (c as Label).Text = "Abc123";
                }
                else if (c is Panel || c is GroupBox)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        if (c2 is Label)
                        {
                            (c2 as Label).Text = "Xyz987";
                        }
                    }
                }
            }      
        }

        private void csokkent_Click(object sender, EventArgs e)
        {
            szam.Text = (int.Parse(szam.Text) - 1).ToString();
        }

        private void novel_Click(object sender, EventArgs e)
        {
            szam.Text = (int.Parse(szam.Text) + 1).ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            szam.Text = "0";
        }

        private void oszt_Click(object sender, EventArgs e)
        {
            szam.Text = (int.Parse(szam.Text) / 2).ToString();
        }

        private void szoroz_Click(object sender, EventArgs e)
        {
            szam.Text = (int.Parse(szam.Text) * 2).ToString();
        }

        private void szam_Click(object sender, EventArgs e)
        {

        }
    }
}
