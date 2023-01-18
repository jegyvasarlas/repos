using System;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inputBox.TextChanged += new EventHandler(InputChanged);
        }

        private void InputChanged(object sender, EventArgs e)
        {
            resultBox.Text = "";
        }

        private void CalculateButtonWithFor_Click(object sender, EventArgs e)
        {
            int input;
            if (int.TryParse(inputBox.Text, out input))
            {
                decimal result = 1;
                for (long i = 1; i <= input; i++)
                {
                    result *= i;
                }
                resultBox.Text = result.ToString();
            }
            else
            {
                resultBox.Text = "Invalid input";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
        }

        private void calculateButtonWithWhile_Click(object sender, EventArgs e)
        {
            int input;
            if (int.TryParse(inputBox.Text, out input))
            {
                decimal result = 1;
                long i = 1;
                while (i <= input)
                {
                    result *= i;
                    i++;
                }
                resultBox.Text = result.ToString();
            }
            else
            {
                resultBox.Text = "Invalid input";
            }
        }
    }
}