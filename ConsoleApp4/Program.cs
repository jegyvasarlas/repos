using System;

namespace ConsoleApp //Gyakorlas1.pdf
{
    internal class Program
    {
        static void Main()
        {
            tizenegy();
            //EgyKettoHaromNegy();
            double egy = 0;
            double ketto = 0;
            while (egy == 0 || ketto == 0)
            {
                Console.WriteLine("Adj meg egy szamot de ne nullat");
                egy = double.Parse(Console.ReadLine());
                Console.WriteLine("Adj meg egy masik szamot de ne nullat");
                ketto = double.Parse(Console.ReadLine());
            }
            if (egy > ketto)
            {
                Console.WriteLine($"Az elso szam ({egy}) nagyobb, mint a masik szam ({ketto})");
                Console.WriteLine("A ket szam hanyadosa: "+egy / ketto);
            }
            else if (ketto > egy)
            {
                Console.WriteLine($"A masik szam ({ketto}) nagyobb, mint az elso szam ({egy})");
                Console.WriteLine("A ket szam hanyadosa: "+ ketto / egy);
            }
            Break();

        }

        static void tizenegy()
        {
            //11
            Console.WriteLine("Adj meg egy szamot 1 es 1 millio kozott");
            int szam = int.Parse(Console.ReadLine());
            if (szam == 1000000)
                Console.WriteLine("7 szamjegy");
            else if (szam / 100000 >= 1)
                Console.WriteLine("6 szamjegy");
            else if (szam / 10000 >= 1)
                Console.WriteLine("5 szamjegy");
            else if (szam / 1000 >= 1)
                Console.WriteLine("4 szamjegy");
            else if (szam / 100 >= 1)
                Console.WriteLine("3 szamjegy");
            else if (szam / 10 >= 1)
                Console.WriteLine("2 szamjegy");
            else
                Console.WriteLine("1 szamjegy");
        }
        static void EgyKettoHaromNegy()
        {
            Console.WriteLine("Add meg az eletkorod");
            byte eletkor = byte.Parse(Console.ReadLine());
            if (eletkor < 18) Console.WriteLine("Nem ihat");
            else Console.WriteLine("Ihat");
            Break();
            //2
            Console.WriteLine("Adj meg egy szamot");
            int masodik = int.Parse(Console.ReadLine());
            if (masodik % 2 == 0) Console.WriteLine("Paros");
            else Console.WriteLine("Paratlan");
            Break();
            //3
            Console.WriteLine("Adj meg egy szamot");
            int harmadik = int.Parse(Console.ReadLine());
            if (harmadik % 5 == 0 && harmadik % 3 == 0)
            {
                Console.WriteLine("5-tel es 3-mal oszthato");
            }
            else if (harmadik % 5 == 0)
            {
                Console.WriteLine("5-tel oszthato");
            }
            else if (harmadik % 3 == 0)
            {
                Console.WriteLine("3-mal oszthato");
            }
            Break();
            //4
            Console.WriteLine("Adj meg egy szamot");
            int negyedik = int.Parse(Console.ReadLine());
            if (negyedik > 0)
            {
                Console.WriteLine("Pozitiv");
            }
            else if (negyedik == 0)
            {
                Console.WriteLine("Nulla");
            }
            else Console.WriteLine("Negativ");
            Break();
            //8
            Console.WriteLine("Adj meg egy szamot 0-9 ig");
            byte szamjegy = byte.Parse(Console.ReadLine());
            switch (szamjegy)
            {
                case 0: Console.WriteLine("Nincs ilyen romai szam"); break;
                case 1: Console.WriteLine("I"); break;
                case 2: Console.WriteLine("II"); break;
                case 3: Console.WriteLine("III"); break;
                case 4: Console.WriteLine("IV"); break;
                case 5: Console.WriteLine("V"); break;
                case 6: Console.WriteLine("VI"); break;
                case 7: Console.WriteLine("VII"); break;
                case 8: Console.WriteLine("VIII"); break;
                case 9: Console.WriteLine("IX"); break;
                default: Console.WriteLine("A megadott szam nem egyjegyu!"); break;
            }
            Break();
            
        }

        static void Break()
        {
            Console.ReadLine();
            Console.Clear();
        }
    }
}