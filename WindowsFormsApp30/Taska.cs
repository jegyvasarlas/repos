using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class Taska : UserControl
    {
        int osszeg;
        bool nyitva;
        static int sajatTaska;

        internal int Osszeg
        {
            get { return osszeg; }
            set { osszeg = value; }
        }

        internal bool Nyitva
        {
            get { return nyitva; }
            set { nyitva = value; }
        }

        static int SajatTaska
        {
            get { return sajatTaska; }
            set { sajatTaska = value; }
        }

        public Taska(int osszeg)
        {
            InitializeComponent();
            nyitva = false;
            pictureBox1.Image = global::WindowsFormsApp30.Properties.Resources.taska_zarva;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.osszeg = osszeg;
        }
    }
}
