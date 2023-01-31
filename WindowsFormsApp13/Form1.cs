using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        static string nev = "";
        static bool entered = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Verseny> versenyek = new List<Verseny>();
            foreach (var sor in File.ReadAllLines("verseny.csv").Skip(1))
            {
                versenyek.Add(new Verseny(sor));
            }
            label1.Text = $"3. feladat: {versenyek.Count}";
            var FurgeFerencGranPrixCircuitHarmadikKorHanyMpAlatt = versenyek.Where(x => x.Versenyzo == "Fürge Ferenc" && x.Palya == "Gran Prix Circuit" && x.Kor == 3).Select(x => x.TotalSecond).First();
            label2.Text="4. feladat: " + FurgeFerencGranPrixCircuitHarmadikKorHanyMpAlatt + " másodperc";

        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Verseny> versenyek = new List<Verseny>();
            foreach (var sor in File.ReadAllLines("verseny.csv").Skip(1))
            {
                versenyek.Add(new Verseny(sor));
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                nev=textBox1.Text.ToString();
                entered = true;
                if (entered == true)
                {
                    try
                    {
                        var BekertNevHolEsMennyiIdoAlattFutottaLeALeggyorsabbKoret = versenyek.Where(x => x.Versenyzo == nev).OrderBy(x => x.TotalSecond).First();
                        label3.Text = $"6. feladat: {BekertNevHolEsMennyiIdoAlattFutottaLeALeggyorsabbKoret.Palya}, {BekertNevHolEsMennyiIdoAlattFutottaLeALeggyorsabbKoret.Korido}";
                        label3.Visible = true;
                    } catch (Exception)
                    {
                        label3.Text = "6. feladat: Nincs ilyen versenyző az állományban!";
                        label3.Visible = true;
                    }
                }
            }
        }
    }

    class Verseny
    {
        public string Csapat { get; private set; }
        public string Versenyzo { get; private set; }
        public int Eletkor { get; private set; }
        public string Palya { get; private set; }
        public string Korido { get; private set; }
        public int Kor { get; private set; }
        public int Hour { get; private set; }
        public int Minute { get; private set; }
        public int Second { get; private set; }
        public int TotalSecond { get; private set; }
        public Verseny(string sor)
        {
            string[] adatok = sor.Split(';');
            Csapat = adatok[0];
            Versenyzo = adatok[1];
            Eletkor = int.Parse(adatok[2]);
            Palya = adatok[3];
            Korido = adatok[4];
            Kor = int.Parse(adatok[5]);
            Hour = int.Parse(Korido.Split(':')[0]);
            Minute = int.Parse(Korido.Split(':')[1]);
            Second = int.Parse(Korido.Split(':')[2]);
            TotalSecond = Hour * 3600 + Minute * 60 + Second;
        }
    }
}
