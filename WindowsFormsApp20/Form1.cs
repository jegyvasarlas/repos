using System;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour < 12)
            {
                this.Text = "Jó reggelt!";
            }
            else if (DateTime.Now.Hour < 18)
            {
                this.Text = "Jó napot!";
            }
            else
            {
                this.Text = "Jó estét!";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int day = dateTimePicker1.Value.Day;
            int month = dateTimePicker1.Value.Month;

            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
            {
                csillagjegy.Text = "Kos";
            }
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
            {
                csillagjegy.Text = "Bika";
            }
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
            {
                csillagjegy.Text = "Ikrek";
            }
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
            {
                csillagjegy.Text = "Rák";
            }
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
            {
                csillagjegy.Text = "Oroszlán";
            }
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
            {
                csillagjegy.Text = "Szűz";
            }
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
            {
                csillagjegy.Text = "Mérleg";
            }
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
            {
                csillagjegy.Text = "Skorpió";
            }
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            {
                csillagjegy.Text = "Nyilas";
            }
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
            {
                csillagjegy.Text = "Bak";
            }
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
            {
                csillagjegy.Text = "Vízöntő";
            }
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
            {
                csillagjegy.Text = "Halak";
            }
        }
    }
}
