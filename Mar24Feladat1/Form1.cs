using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;

namespace Mar24Feladatok
{
    public partial class Form1 : Form
    {
        int red;
        int green;
        int blue;
        ColorDialog cd;
        public Form1()
        {
            InitializeComponent();
            red = green = blue = 0;
            cd = new ColorDialog();
        }

        private void Beallitas(object sender, EventArgs e)
        {
            cd.ShowDialog();
            red = cd.Color.R;
            green = cd.Color.G;
            blue = cd.Color.B;
            szin.BackColor = Color.FromArgb(red, green, blue);
            label1.Text = $"Kivalasztott szin RGB kodja: Color.FromArgb({red}, {green}, {blue});";
        }
    }
}
