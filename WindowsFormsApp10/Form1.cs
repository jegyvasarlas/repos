using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            int egerX = e.X;
            int egerY = e.Y;
            int labelWidth = label1.Width;
            int labelHeight = label1.Height;

            int x = egerX / (labelWidth / 3);
            int y = egerY / (labelHeight / 3);
            
            switch (y * 3 + x)
            {
                case 0:
                    label1.TextAlign = ContentAlignment.TopLeft;
                    break;
                case 1:
                    label1.TextAlign = ContentAlignment.TopCenter;
                    break;
                case 2:
                    label1.TextAlign = ContentAlignment.TopRight;
                    break;
                case 3:
                    label1.TextAlign = ContentAlignment.MiddleLeft;
                    break;
                case 4:
                    label1.TextAlign = ContentAlignment.MiddleCenter;
                    break;
                case 5:
                    label1.TextAlign = ContentAlignment.MiddleRight;
                    break;
                case 6:
                    label1.TextAlign = ContentAlignment.BottomLeft;
                    break;
                case 7:
                    label1.TextAlign = ContentAlignment.BottomCenter;
                    break;
                case 8:
                    label1.TextAlign = ContentAlignment.BottomRight;
                    break;
            }
        }
    }
}
