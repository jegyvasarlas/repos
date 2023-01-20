using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Scroll_ValueChanged(object sender, EventArgs e)
        {
            int R = redScroll.Value;
            int G = greenScroll.Value;
            int B = blueScroll.Value;
            int O = 255-opacityScroll.Value;
            Color color = Color.FromArgb(O, R, G, B);
            Hatterszin.BackColor = color;
            if (sender is HScrollBar)
            {
                redNumeric.Value = redScroll.Value;
                blueNumeric.Value = blueScroll.Value;
                greenNumeric.Value = greenScroll.Value;
                opacityNumeric.Value = opacityScroll.Value;
            }
        }

        private void Numeric_ValueChanged(object sender, EventArgs e)
        {
            int R = (int)redNumeric.Value;
            int G = (int)greenNumeric.Value;
            int B = (int)blueNumeric.Value;
            int O = 255 - (int)opacityNumeric.Value;
            Color color = Color.FromArgb(O, R, G, B);
            Hatterszin.BackColor = color;
            if (sender is NumericUpDown)
            {
                redScroll.Value = (int)redNumeric.Value;
                blueScroll.Value = (int)blueNumeric.Value;
                greenScroll.Value = (int)greenNumeric.Value;
                opacityScroll.Value = (int)opacityNumeric.Value;
            }
        }
    }
}
