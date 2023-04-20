using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace futoverseny2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Versenyzo
        {
            public string Rajtszam { get; private set; }
            public string Nev { get; private set; }
            public string SzulDatum { get; private set; }
            public string Orszag { get; private set; }
            public string Ido { get; private set; }

            public Versenyzo(string sor)
            {
                string[] a = sor.Split(';');
                Rajtszam = a[0];
                Nev = a[1];
                SzulDatum = a[2];
                Orszag = a[3];
                Ido = a[4];
            }

            public override string ToString()
            {
                return Rajtszam + ";" + Nev + ";" + SzulDatum + ";" + Orszag + ";" + Ido;
            }
        }
        
        static List<Versenyzo> versenyzok = new List<Versenyzo>();
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var i in File.ReadAllLines("futok.txt"))
            {
                versenyzok.Add(new Versenyzo(i));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var i in versenyzok)
            {
                listBox1.Items.Add(i.Nev);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
