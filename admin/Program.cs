using System;
using System.IO;

namespace admin
{
    class Tanulok
    {
        public int Ev { get; set; }
        public char Osztaly { get; set; }
        public string VNev { get; set; }
        public string KNev { get; set; }
        public string Nev { get; set; }
        

        public Tanulok(string sor)
        {
            string[] m = sor.Split(' ');
            Ev = Convert.ToInt32(m[0]);
            Osztaly = char.Parse(m[1]);
            VNev = Convert.ToString(m[2]);
            KNev = Convert.ToString(m[3]);
            Nev = VNev + " " + KNev;
        }
    }

    class Program
    {
        static void Main()
        {
            // 1. feladat
            Tanulok[] students = new Tanulok[File.ReadAllLines("nevek.txt").Length];
            Tanulok[] tanulok = new Tanulok[10];

            tanulok[0] = new Tanulok("2006 c Bodnar Szilvia");
            tanulok[1] = new Tanulok("2005 b Rasztik Gyorgy");
            tanulok[2] = new Tanulok("2006 e Muller Reka");
            tanulok[3] = new Tanulok("2005 b Maltesics Fanni");
            tanulok[4] = new Tanulok("2007 a Csermak Edit");
            tanulok[5] = new Tanulok("2007 c Boros Petra");
            tanulok[6] = new Tanulok("2004 d Gaal Daniel");
            tanulok[7] = new Tanulok("2007 a Hirth Ferenc");
            tanulok[8] = new Tanulok("2004 a Nagy Katalin");
            tanulok[9] = new Tanulok("2004 d Csepregi Daniel"); // feladat szerint lehet az elso 10 zel tovabb haladni ha nem megy a bolvasas
            
            /*for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Tanulok(File.ReadAllText("nevek.txt"));
            }*/
            // 2. feladat
            Console.WriteLine($"2. feladat: {students.Length} db tanulo jar az iskolaba.");
            // note to self : ha marad ido beolvasni a tobbit for ciklussal 

            // 3. feladat
            Console.Write("Adj meg egy evfolyamot: ");
            int haromev = int.Parse(Console.ReadLine());
            Console.Write("Adj meg egy osztalyt: ");
            char haromosztaly = char.Parse(Console.ReadLine());
            foreach (var item in tanulok)
            {
                if (item.Ev == haromev && item.Osztaly == haromosztaly)
                    Console.WriteLine(item.Nev);
            }

            Console.ReadKey(); // Nem volt ido befejezni igy linq meg lista nelkul
        }
    }
}
