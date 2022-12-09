using System;

namespace Osztalyok
{
    class Cim
    {
        private int iranyitoszam;
        public int Iranyitoszam
        {
            set
            {
                if(value >= 1000 && value <= 9999)
                    iranyitoszam = value;
            }
        }
        private string telepules;
        private string utca;
        private int hazszam;
        public int Hazszam
        {
            set
            {
                if (value >= 1)
                    hazszam = value;
            }
        }

        public Cim(int iranyitoszam, string telepules, string utca, int hazszam)
        {
            Iranyitoszam=iranyitoszam;
            this.telepules = telepules;
            this.utca = utca;
            Hazszam = hazszam;
        }

        // Masolo konstruktor
        public Cim(Cim masik)
        {
            this.iranyitoszam = masik.iranyitoszam;
            this.telepules = masik.telepules;
            this.utca = masik.utca;
            this.hazszam = masik.hazszam;
        }
        public void Kiir()
        {
            Console.Write(iranyitoszam+", "+telepules+" "+utca+" u. "+hazszam);
        }
    }
}
