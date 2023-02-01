using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        static Random r = new Random();
        int count, maximum, minimum;
        double avg, sum;
        public Form1()
        {
            InitializeComponent();
            count = 0;
            maximum = int.MinValue;
            minimum = int.MaxValue;
            avg = 0;
            sum = 0;
        }
        
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Label l = new Label();
            l.Name = "label";
            int szam = r.Next(1, 101);
            l.Text = szam.ToString();
            l.Location = new Point(e.X, e.Y);
            l.AutoSize = true;
            
            darab.Text = (++count).ToString();
            sum += szam;
            avg = sum / (double)count;
            atlag.Text = avg.ToString();
            
            if (szam > maximum)
            {
                maximum = szam;
                max.Text = maximum.ToString();
            }
            if (szam < minimum)
            {
                minimum = szam;
                min.Text = minimum.ToString();
            }
            
            this.Controls.Add(l);
        }
    }
}