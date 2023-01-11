using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc()
        {
            string bemenet = Bemenet.Text;
            try
            {
                double szam = double.Parse(bemenet);
                if (szam < 0)
                {
                    throw new Exception("Nem pozitiv a beirt szam!");
                }
                MessageBox.Show($"A beolvasott szam:  {szam} {Environment.NewLine}{Environment.NewLine}Negyzete: {szam * szam}{Environment.NewLine}Kobe: {szam * szam * szam}{Environment.NewLine}Negyzetgyoke: {Math.Sqrt(szam)}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Szamol(object sender, EventArgs e)
        {
            Calc();
        }

        private void Gombnyomas(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Calc();
            }
        }
    }
}
