using System;

namespace Delegate2
{
    class Program
    {
        public delegate double Matekozas(double szam);
        public static Matekozas m;

        public delegate int CsinalValamit(int x);

        public static int Kiszamol(int szam, CsinalValamit csinal)
        {
            int eredmeny = csinal(szam);
            return eredmeny;
        }

        public static double Negyzet(double szam)
        {
            Console.WriteLine(szam * szam);
            return szam * szam;
        }
        
        public static double Gyok(double szam)
        {
            Console.WriteLine(Math.Sqrt(szam));
            return Math.Sqrt(szam);
        }
        
        public static double Log(double szam)
        {
            Console.WriteLine(Math.Log10(szam));
            return Math.Log10(szam);
        }
        
        public static void Main(string[] args)
        {
            m += Negyzet;
            m += Gyok;
            m += Log;

            m(10);
            
            int eredmeny = Kiszamol(22, x => x * 2);
            int eredmeny2 = Kiszamol(13, Osztas);
            
        }
        public static int Osztas(int szam)
        {
            return szam / 2;
        }
    }
}