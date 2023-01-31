using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        private PictureBox[] kepek;
        public Form1()
        {
            InitializeComponent();
            kepek = new PictureBox[8];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int R = 300;
            int alpha;
            int szog = 360 / 8;
            for (int i = 0; i < kepek.Length; i++)
            {
                alpha = i * szog;
                kepek[i] = new PictureBox();
                kepek[i].Image = Image.FromFile(@"..\..\Resources\_" + (i + 1).ToString() + ".jpg");
                kepek[i].Size = new Size(100, 100);
                int x = (int)(R * Math.Cos((double)alpha/180*Math.PI) + ClientSize.Width/2 - kepek[i].Width/2);
                int y = (int)(R * Math.Sin((double)alpha/180*Math.PI) + ClientSize.Height/2 - kepek[i].Height/2);
                kepek[i].Location = new Point(x, y);
                kepek[i].Name = "pictureBox" + (i + 1);
                kepek[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(kepek[i]);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Image tmp = kepek[0].Image;
            for (int i = 1; i < kepek.Length; i++)
            {
                kepek[i - 1].Image = kepek[i].Image;
            }
            kepek[kepek.Length - 1].Image = tmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image tmp = kepek[kepek.Length - 1].Image;
            for (int i = kepek.Length - 1; i > 0; i--)
            {
                kepek[i].Image = kepek[i - 1].Image;
            }
            kepek[0].Image = tmp;
        }
    }
}