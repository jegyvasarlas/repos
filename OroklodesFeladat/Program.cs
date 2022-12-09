using System;

namespace OroklodesFeladat
{
    class Adat
    {
        protected double a;
        protected double b;
        protected double eredmeny;
        public virtual double Szamol()
        {
            eredmeny = (a + b) / 2;
            return eredmeny;
        }
        public Adat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public virtual void Kiir()
        {
            Console.Write("Szamtani kozep: ");
            Szamol();
            Console.WriteLine(eredmeny);
        }
    }

    class UjAdat: Adat
    {
        protected double osszeg;
        public UjAdat(double a, double b): base(a, b)
        {
            OsszegSzamol();
        }
        public new double Szamol()
        {
            return Math.Sqrt(a * b);
        }
        public void OsszegSzamol()
        {
            osszeg = a + b;
        }
        public override void Kiir()
        {
            base.Kiir();
        }
        public void UjKiir()
        {
            Kiir();
            Console.WriteLine("Mertani kozep: " + Szamol());
            Console.WriteLine("Osszeg: " + osszeg);
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            UjAdat a = new UjAdat(2, 5);
            a.UjKiir();
            Console.ReadKey();
        }
    }
}
