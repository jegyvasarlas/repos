using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp27
{
    public partial class Form1 : Form
    {
        static Random r = new Random();
        int szam;
        public Form1()
        {
            InitializeComponent();
        }

        private void General_Click(object sender, EventArgs e)
        {
            szam = r.Next(1, 21);
            button1.Enabled = button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (szam % 2 == 0)
            {
                MessageBox.Show("Nyertél!", "Eredmény", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vesztettél!", "Eredmény", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (szam % 2 == 1)
            {
                MessageBox.Show("Nyertél!", "Eredmény", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vesztettél!", "Eredmény", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            if (form2.ShowDialog() == DialogResult.Yes)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }
    }
}
