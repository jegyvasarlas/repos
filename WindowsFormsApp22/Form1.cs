using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        enum Irany
        {
            jobbra,
            le,
            balra,       
            fel
        }
        static Color[] szinek = new Color[]
        {
            Color.CadetBlue,
            Color.DarkGray,
            Color.Green,
            Color.NavajoWhite,
            Color.SteelBlue,
            Color.PeachPuff,
            Color.Tomato,
            Color.Peru,
            Color.Red,
            Color.Blue,
            Color.Yellow,
            Color.Green,
            Color.Pink,
            Color.Orange,
            Color.Purple,
            Color.Brown,
            Color.Black,
            Color.White,
            Color.Gray,
            Color.Aqua,
            Color.Aquamarine,
            Color.Azure,
            Color.Beige,
            Color.Bisque,
            Color.BlanchedAlmond,
            Color.BlueViolet,
            Color.Chartreuse,
            Color.Coral,
            Color.DarkCyan,
            Color.DarkOrange,
            Color.DeepPink,
            Color.Gold,
            Color.Indigo,
            Color.Khaki,
            Color.Lavender,
            Color.MediumPurple,
            Color.MistyRose,
            Color.Navy,
            Color.Olive,
            Color.OrangeRed,
            Color.RosyBrown,
            Color.SaddleBrown,
            Color.Salmon,
            Color.SandyBrown,
            Color.SlateGray,
            Color.SpringGreen,
            Color.Tan,
            Color.Teal,
            Color.Violet,
            Color.Wheat,
        };

        static int counter;
        static int c2;
        int counter2;
        int x, y;
        int width, height, fWidth, fHeight;
        Irany irany;
        int lepes;


        public Form1()
        {
            InitializeComponent();
            counter = c2  = 0;
            counter2 = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string ora = dt.Hour.ToString().PadLeft(2, '0');
            string perc = dt.Minute.ToString().PadLeft(2, '0');
            string mp = dt.Second.ToString().PadLeft(2, '0');
            string ms = dt.Millisecond.ToString().PadLeft(3, '0');
            label1.Text = ora + ":" + perc + ":" + mp + ":" + ms;
            counter++;
            if (counter == 50)
            {
                this.BackColor = szinek[c2];
                counter = 0;
                c2++;
                if (c2 == szinek.Length)
                {
                    c2 = 0;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.FormCime = counter2.ToString();
            f.Show();
            counter2++;
            if (counter2 == 30)
            {
                timer2.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = y = 0;
            width = Screen.PrimaryScreen.Bounds.Width;
            height = Screen.PrimaryScreen.Bounds.Height;
            fWidth = this.Width;
            fHeight = this.Height;
            irany = Irany.jobbra;
            lepes = 10;
            this.Location = new Point(x, y);
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            this.Text = "waaaaaaaaaaa gocrazyy";
            if (irany == Irany.jobbra)
                x += lepes;
            else if (irany == Irany.le)
                y += lepes;
            else if (irany == Irany.balra)
                x -= lepes;
            else if (irany == Irany.fel)
                y -= lepes;
            if (x > (width - fWidth))
            {
                irany++;
                x = width - fWidth;
            }
            else if (y > (height - fHeight))
            {
                irany++;
                y = height - fHeight;
            }
            else if (x < 0)
            {
                irany++;
                x = 0;
            }
            else if (y < 0)
            {
                irany = Irany.jobbra;
                y = 0;
            }
            this.Location = new Point(x, y);
        }
    }
}
