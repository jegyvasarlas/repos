using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        private byte[] tomb;

        private Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            tomb = new byte[6];
            
        }
        
        private void feltoltButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = (byte)r.Next(1, 21);
            }
            megjelenitButton.Enabled = true;
        }

        private void megjelenitButton_Click(object sender, EventArgs e)
        {
            AdatokLista.Items.Clear();
            for (int i = 0; i < tomb.Length; i++)
            {
                AdatokLista.Items.Add(tomb[i]);
            }
            szamolButton.Enabled = true;
        }

        private void szamolButton_Click(object sender, EventArgs e)
        {
            minBox.Text = tomb.Min().ToString();
            maxBox.Text = tomb.Max().ToString();
            
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            avgBox.Text = ((double)osszeg / tomb.Length).ToString();
        }

        private void kilepesButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}