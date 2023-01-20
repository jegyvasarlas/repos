using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        int width;
        int height;
        
        public Form1()
        {
            InitializeComponent();
            width = Screen.PrimaryScreen.Bounds.Width;
            height = Screen.PrimaryScreen.Bounds.Height;
        }

        // Bal felso
        private void button1_Click(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
        }

        // Bal also
        private void button2_Click(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = height - this.Height;
        }

        // Jobb felso
        private void button3_Click(object sender, EventArgs e)
        {
            this.Left = width - this.Width;
            this.Top = 0;
        }

        // Jobb also
        private void button4_Click(object sender, EventArgs e)
        {
            this.Left = width - this.Width;
            this.Top = height - this.Height;
        }

        // make it spin around
        private void button5_Click(object sender, EventArgs e)
        {
            int x = this.Left;
            int y = this.Top;
            int w = this.Width;
            int h = this.Height;
            int i = 0;
            while (true)
            {
                this.Left = x + (int)(Math.Cos(i) * w);
                this.Top = y + (int)(Math.Sin(i) * h);
                i++;
                Thread.Sleep(10);
            }
        }
    }
}
