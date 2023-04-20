using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegyenOnIsMilliomos
{
    public partial class Jatek : UserControl
    {
        int aktualisSzint;

        public int Pontszam
        {
            get
            {
                if (aktualisSzint == 15)
                    return 15 * 15;
                else
                    return (int)Math.Pow(aktualisSzint - 1, 2);
            }
        }

        Kerdes aktualisKerdes;

        public Jatek()
        {
            InitializeComponent();
            aktualisSzint = 1;
            AValasz.Click += ValaszClick;
            BValasz.Click += ValaszClick;
            CValasz.Click += ValaszClick;
            DValasz.Click += ValaszClick;
        }

        public void UjJatek()
        {
            aktualisSzint = 1;
            KovetkezoKerdes();
            AValasz.Enabled
            = BValasz.Enabled
            = CValasz.Enabled
            = DValasz.Enabled = true;
        }

        private void KovetkezoKerdes()
        {
            aktualisKerdes = new Kerdes(aktualisSzint);

            Kerdes.Text = aktualisKerdes.nehezseg + ". kérdés: " + aktualisKerdes.kerdes;
            AValasz.Text = aktualisKerdes.A;
            BValasz.Text = aktualisKerdes.B;
            CValasz.Text = aktualisKerdes.C;
            DValasz.Text = aktualisKerdes.D;
        }

        private void Jatek_Load(object sender, EventArgs e)
        {
            KovetkezoKerdes();
        }

        private void ValaszClick(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                Button megnyomott = sender as Button;

                char c = megnyomott.Name[0];        // A/B/C/D

                if(c == aktualisKerdes.helyes)
                {
                    if(aktualisSzint==15)
                    {
                        MessageBox.Show("Gratulálok! Minden kérdésre jól válaszoltál!"
                                        + Environment.NewLine +
                                        "A Te pontszámod: " + Pontszam
                                        + Environment.NewLine +
                                        "Iratkozz fel a rangsorra!");

                        AValasz.Enabled
                        = BValasz.Enabled
                        = CValasz.Enabled
                        = DValasz.Enabled = false;

                        RanglistaFeliratkozasDialog r = new RanglistaFeliratkozasDialog(Pontszam);
                        r.ShowDialog();

                        return;
                    }

                    aktualisSzint++;
                    KovetkezoKerdes();
                }
                else
                {                    
                    MessageBox.Show("Helytelen válasz, vége a játéknak."
                                    + Environment.NewLine + 
                                    "A Te pontszámod: " + Pontszam
                                    + Environment.NewLine +
                                    "Iratkozz fel a rangsorra!");

                    AValasz.Enabled 
                    = BValasz.Enabled 
                    = CValasz.Enabled 
                    = DValasz.Enabled = false;

                    RanglistaFeliratkozasDialog r = new RanglistaFeliratkozasDialog(Pontszam);
                    r.ShowDialog();
                }
            }
        }
    }    
}
