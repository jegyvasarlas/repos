using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        static double ossz = 0;
        const int budapestAr = 1500;
        const int hatvanAr = 1300;
        const int szekesfehervarAr = 2000;
        const int kecskemetAr = 2800;
        const int kutyaAr = 800;
        const int bicikliAr = 600;
        const int tulmeretesPoggyaszAr = 400;
        bool isBudapest = false;
        bool isHatvan = false;
        bool isSzekesfehervar = false;
        bool isKecskemet = false;
        bool isNappaliTagozatosDiak = false;
        bool isNyugdijas = false;
        bool isTorzsutasKartya = false;
        bool isKutya = false;
        bool isBicikli = false;
        bool isTulmeretesPoggyasz = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void budapest_CheckedChanged(object sender, EventArgs e)
        {
            if (budapest.Checked)
            {
                isBudapest = true;
                if (isTorzsutasKartya)
                {
                    ossz = budapestAr * 0.3;
                    osszeg.Text = ossz.ToString() + " Ft";
                }
                else
                {
                    if (isNyugdijas || isNappaliTagozatosDiak)
                    {
                        ossz = budapestAr / 2;
                        osszeg.Text = ossz.ToString() + " Ft";
                    }
                    else
                    {
                        ossz = budapestAr;
                        osszeg.Text = ossz.ToString() + " Ft";
                    }
                }
                
            }
            else
            {
                isBudapest = false;
            }
        }

        private void hatvan_CheckedChanged(object sender, EventArgs e)
        {
            if (hatvan.Checked)
            {
                isHatvan = true;
                if (isTorzsutasKartya)
                {
                    ossz = hatvanAr * 0.3;
                    osszeg.Text = ossz.ToString() + " Ft";
                }
                else
                {
                    if (isNyugdijas || isNappaliTagozatosDiak)
                    {
                        ossz = hatvanAr / 2;
                        osszeg.Text = ossz.ToString() + " Ft";
                    }
                    else
                    {
                        ossz = hatvanAr;
                        osszeg.Text = ossz.ToString() + " Ft";
                    }
                }
            }
            else
            {
                isHatvan = false;
            }
        }

        private void szekesfehervar_CheckedChanged(object sender, EventArgs e)
        {
            if (szekesfehervar.Checked)
            {
                isSzekesfehervar = true;
                if (isTorzsutasKartya)
                {
                    ossz = szekesfehervarAr * 0.3;
                    osszeg.Text = ossz.ToString() + " Ft";
                }
                else
                {
                    if (isNyugdijas || isNappaliTagozatosDiak)
                    {
                        ossz = szekesfehervarAr / 2;
                        osszeg.Text = ossz.ToString() + " Ft";
                    }
                    else
                    {
                        ossz = szekesfehervarAr;
                        osszeg.Text = ossz.ToString() + " Ft";
                    }
                }
            }
            else
            {
                isSzekesfehervar = false;
            }
        }

        private void kecskemet_CheckedChanged(object sender, EventArgs e)
        {
            if (kecskemet.Checked)
            {
                isKecskemet = true;
                if (isTorzsutasKartya)
                {
                    ossz = kecskemetAr * 0.3;
                    osszeg.Text = ossz.ToString() + " Ft";
                }
                else
                {
                    if (isNyugdijas || isNappaliTagozatosDiak)
                    {
                        ossz = kecskemetAr / 2;
                        osszeg.Text = ossz.ToString() + " Ft";
                    }
                    else
                    {
                        ossz = kecskemetAr;
                        osszeg.Text = ossz.ToString() + " Ft";
                    }
                }
            }
            else
            {
                isKecskemet = false;
            }
        }

        private void nappaliTagozatosDiak_CheckedChanged(object sender, EventArgs e)
        {
            if (nappaliTagozatosDiak.Checked)
            {
                isNappaliTagozatosDiak = true;
                nyugdijas.Checked = false;
                nyugdijas.Enabled = false;
            }
            else
            {
                isNappaliTagozatosDiak = false;
                nyugdijas.Enabled = true;
            }
        }

        private void nyugdijas_CheckedChanged(object sender, EventArgs e)
        {
            if (nyugdijas.Checked)
            {
                isNyugdijas = true;
                nappaliTagozatosDiak.Checked = false;
                nappaliTagozatosDiak.Enabled = false;
            }
            else
            {
                isNyugdijas = false;
                nappaliTagozatosDiak.Enabled = true;
            }
        }

        private void torzsutasKartya_CheckedChanged(object sender, EventArgs e)
        {
            if (torzsutasKartya.Checked)
            {
                isTorzsutasKartya = true;
            }
            else
            {
                isTorzsutasKartya = false;
            }
        }
    }
}
