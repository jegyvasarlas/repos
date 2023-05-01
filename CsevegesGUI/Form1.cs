using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace CsevegesGUI
{
    public partial class Form1 : Form
    {
        List<Beszelgetes> beszelgetesek = new List<Beszelgetes>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var sor in File.ReadAllLines("csevegesek.txt").Skip(1))
            {
                beszelgetesek.Add(new Beszelgetes(sor));
            }

            Kezdemenyezo.Items.AddRange(beszelgetesek.Select(b => b.Kezdemenyezo).Distinct().ToArray());
            
            Fogado.Items.AddRange(beszelgetesek.Select(b => b.Fogado).Distinct().ToArray());
        }


        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            Csevegesek.Items.Clear();
            string kezdemenyezo = (string)Kezdemenyezo.SelectedItem;
            string fogado = (string)Fogado.SelectedItem;
            int sorszam = 1;
            foreach (var b in beszelgetesek)
            {
                if (b.Kezdemenyezo == kezdemenyezo && b.Fogado == fogado)
                {
                    Csevegesek.Items.Add($"{sorszam++}. {b.Kezdet.ToString("yy.MM.dd-HH:mm:ss")} --> {b.Veg.ToString("yy.MM.dd-HH:mm:ss")}");
                }
            }
            if (Csevegesek.Items.Count == 0) Csevegesek.Items.Add("Nem tortent beszelgetes.");
        }
    }

    class Beszelgetes
    {
        public DateTime Kezdet { get; private set; }
        public DateTime Veg { get; private set; }
        public string Kezdemenyezo { get; private set; }
        public string Fogado { get; private set; }
        public Beszelgetes(string sor)
        {
            string[] adatok = sor.Split(';');
            Kezdet = DateTime.ParseExact(adatok[0], "yy.MM.dd-HH:mm:ss", CultureInfo.InvariantCulture);
            Veg = DateTime.ParseExact(adatok[1], "yy.MM.dd-HH:mm:ss", CultureInfo.InvariantCulture);
            Kezdemenyezo = adatok[2];
            Fogado = adatok[3];
        }
    }
}
