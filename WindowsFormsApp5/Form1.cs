using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void Szamitas(object sender, EventArgs e)
        {
            char[] ops = new char[] { '+', '-', '*', '/' };
            string muvelet = kijelzo.Text;
            int op_index = muvelet.IndexOfAny(ops);
            double x = double.Parse(muvelet.Substring(0, op_index));
            double y = double.Parse(muvelet.Substring(op_index + 1));
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
            }
            kijelzo.Text += "=" + eredmeny.ToString();
        }
    }
}