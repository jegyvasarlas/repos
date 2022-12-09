using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        /* Olvassunk be egy poz. egész számot, majd határozzuk meg az osztóit 
            pl.: 36: 1, 2, 3, 4, 6, 9, 12, 18, 36 */

        /* Olvassunk be egy poz. egész számot és határozzuk meg, hogy hány osztója van. */

        /* Olvassunk be egy poz. egész számot, majd mondjuk meg róla, hogy prím-e. */
        static void Main(string[] args)
        {
            //Egy();
            //Ketto();
            //Harom();
            Negy();
        }
        static void Negy()
        {
            // 220 284
            Console.WriteLine("Adj meg egy pozitiv egesz szamot");
            int egyik_szam = int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy masik pozitiv egesz szamot");
            int masik_szam = int.Parse(Console.ReadLine());
            int osztok_osszege_1 = 0;
            int osztok_osszege_2 = 0;
            for (int i = 1; i < egyik_szam; i++)
            {
                if (egyik_szam % i == 0)
                {
                    osztok_osszege_1 = osztok_osszege_1 + i;
                }
            }
            for (int i = 1; i < masik_szam; i++)
            {
                if (masik_szam % i == 0)
                {
                    osztok_osszege_2 = osztok_osszege_2 + i;
                }
            }
            if (osztok_osszege_1 == masik_szam || osztok_osszege_2 == egyik_szam)
            {
                Console.WriteLine("Baratsagos szamok");
            }
            else
            {
                Console.WriteLine("Nem baratsagos szamok");
            }
        }
        static void Harom()
        {
            Console.WriteLine("Adj meg egy pozitiv egesz szamot");
            long i = long.Parse(Console.ReadLine());
            if (i == 2)
            {
                Console.WriteLine("Prim");
            }
            else if (i%2==0)
            {
                Console.WriteLine("Nem prim");
            }
            else
            {
                bool b = true;
                for (long j = 3; j*j <= i && b; j=j+2)
                {
                    if (i % j == 0)
                    {
                        Console.WriteLine("Nem prim");
                        b = false;
                    }
                }
                if (b) Console.WriteLine("Prim");
            }
        }
        static void Ketto()
        {
            Console.WriteLine("Adj meg egy pozitiv egesz szamot");
            int i = int.Parse(Console.ReadLine());
            int sz = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    sz++;
                }
            }
            Console.WriteLine($"A(z) {i} -nak/-nek {sz} darab osztoja van");
        }
        static void Egy()
        {
            Console.WriteLine("Adj meg egy pozitiv egesz szamot");
            int i = int.Parse(Console.ReadLine());
            Console.Write($"{i}: ");   
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    Console.Write($"{j} ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}