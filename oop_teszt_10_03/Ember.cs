using System;

namespace Osztalyok
{
    class Ember
    {
        private string nev;
        private int eletkor;
        public int Eletkor
        {
            get { return eletkor; }
            set
            {
                if (value >= 0 && value <= 120)
                    eletkor = value;
            }
        }
        private bool nem;
        private string foglalkozas;
        private Cim cim;
        public Cim Cim
        {
            set
            {
                this.cim = new Cim(value);
            }
            get { return cim; }
        }

        // Konstruktor -> inicializaciokor hivodik
        // PUBLIC MINDIG
        // Osztay neve a neve
        // Nincs visszaterese, az se hogy void

        public Ember(string nev, int eletkor, bool nem, string foglalkozas, Cim cim)
        {
            this.nev = nev;
            SetEletkor(eletkor);
            this.nem = nem;
            this.foglalkozas = foglalkozas;
            //this.cim = cim; // Sekely masolas, referenciat masolunk
            this.cim = new Cim(cim); // Mely masolas, ertek masolas
        }

        public void SetEletkor(int eletkor)
        {
            if (eletkor >= 0 && eletkor <= 120)
                this.eletkor = eletkor;
        }

        public int GetEletkor()
        {
            return eletkor;
        }

        public void Kiir()
        {
            Console.WriteLine("Nev: " + nev + ", Eletkor: " + eletkor);
            Console.WriteLine("Nem: "+(nem?"ferfi":"no")+", Foglalkozas: "+foglalkozas);
            Console.Write("Cim: ");
            cim.Kiir();
            Console.WriteLine();
        }

        public void SetIranyitoszam(int iranyitoszam)
        {
            cim.Iranyitoszam = iranyitoszam;
        }

    }
}
