using System;

namespace Tort
{
    class Program
    {
        static void Main(string[] args)
        {
            Tort t1 = new Tort(2, 3);
            Tort t2 = new Tort(3, 4);
            
            Tort t3 = t1 + t2;
            t3.Kiir();

            Tort t4 = t3 + 2;

            Tort t5 = t1 - t2;
            t5.Kiir();

            Tort t6 = new Tort(2,3) * new Tort(11,13);
            t6.Kiir();

            Console.WriteLine(t2 == t5);

            Tort t8 = new Tort(1, 2);
            Tort t9 = new Tort(1, 2);
            Console.WriteLine(t8 == t9);

            Tort t10 = new Tort(128, 256);
            t10.Kiir();

            Console.ReadKey();
        }
    }
}
