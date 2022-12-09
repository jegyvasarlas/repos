using System;

namespace Alakzatok
{
    abstract class Alakzat
    {
        public abstract double Terulet();
        public abstract double Kerulet();
        public double HosszusagVizsgal(double l)
        {
            if(l >= 0)
                return l;
            else
                return Math.Abs(l);
        }
        public void Kiir()
        {
            Console.WriteLine("Kerulet: " + Kerulet());
            Console.WriteLine("Terulet: " + Terulet());
        }
    }

    class Teglalap: Alakzat
    {
        protected double a;
        protected double b;
        public Teglalap(double a, double b)
        {
            this.a = HosszusagVizsgal(a);
            this.b = HosszusagVizsgal(b);
        }
        public override double Terulet()
        {
            return (a * b);
        }
        public override double Kerulet()
        {
            return (a + b) * 2;
        }
    }

    class Kor: Alakzat
    {
        protected double r;
        public Kor(double r)
        {
            this.r = HosszusagVizsgal(r);
        }
        public override double Terulet()
        {
            return r * r * Math.PI;
        }
        public override double Kerulet()
        {
            return 2*r*Math.PI;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Teglalap t = new Teglalap(2, 3);
            Kor k = new Kor(10);

            t.Kiir();
            k.Kiir();

            // Heterogen kollekcio
            Alakzat[] alakzatok = new Alakzat[4];
            alakzatok[0] = new Teglalap(8, 1.2);
            alakzatok[1] = new Kor(4);
            alakzatok[2] = new Kor(-123);
            alakzatok[3] = new Teglalap(-2, 7);

            for (int i = 0; i < alakzatok.Length; i++)
            {
                if (alakzatok[i] is Teglalap)
                    Console.WriteLine("Teglalap: ");
                else if (alakzatok[i] is Kor)
                    Console.WriteLine("Kor: ");
                
                alakzatok[i].Kiir();
            }

            Console.ReadKey();
        }
    }
}
