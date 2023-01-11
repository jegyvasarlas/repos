using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void GombNyomas(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                kijelzo.Text += (sender as Button).Text;
            }
        }

        private void Torles(object sender, EventArgs e)
        {
            kijelzo.Text = String.Empty;
            if (sender is Button)
            {
                foreach (Button b in this.Controls.OfType<Button>())
                {
                    b.Enabled = true;
                }
            }
        }

        private void Szamitas(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                foreach (Button b in this.Controls.OfType<Button>())
                {
                    b.Enabled = false;
                }
            }
            reset.Enabled = true;
            char[] ops = new char[] { '+', '-', '*', '/', '^', '%' };
            string muvelet = kijelzo.Text;
            bool negativ = false;
            if (muvelet[0] == '-')
            {
                negativ = true;
                muvelet = muvelet.Substring(0,1);
            }
            int op_index = muvelet.IndexOfAny(ops);
            double x = double.Parse(muvelet.Substring(0, op_index));
            double y = double.Parse(muvelet.Substring(op_index + 1));
            if (negativ) x *= -1;
            double eredmeny = 0;
            switch (muvelet[op_index])
            {
                case '+':
                    eredmeny = x + y;
                    break;
                case '-':
                    eredmeny = x - y;
                    break;
                case '*':
                    eredmeny = x * y;
                    break;
                case '/':
                    eredmeny = x / y;
                    break;
                case '^':
                    eredmeny = Math.Pow(x, y);
                    break;
                case '%':
                    eredmeny = x % y;
                    break;
            }
            kijelzo.Text += "=" + eredmeny.ToString();
        }
        
        private void Backspace(object sender, EventArgs e)
        {
            if (kijelzo.Text.Length > 0)
            {
                kijelzo.Text = kijelzo.Text.Substring(0, kijelzo.Text.Length - 1);
            }
        }
    }
}