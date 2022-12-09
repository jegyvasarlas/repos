using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace VizibicikliKolcsonozo
{
    class Kolcsonzes
    {
        public string Nev { get; set; }
        public char JAzon { get; set; }
        public int EOra { get; set; }
        public int EPerc { get; set; }
        public int VOra { get; set; }
        public int Vperc { get; set; }
        public Kolcsonzes(string sor)
        {
            string[] m = sor.Split(';');
            Nev = m[0];
            JAzon = char.Parse(m[1]);
            EOra = Convert.ToInt32(m[2]);
            EPerc = Convert.ToInt32(m[3]);
            VOra = Convert.ToInt32(m[4]);
            Vperc = Convert.ToInt32(m[5]);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //5. feladat
            List<Kolcsonzes> list = new List<Kolcsonzes>();
            foreach (var item in File.ReadAllLines(@"C:\Users\admin\Downloads\kolcsonzesek.txt").Skip(1))
            {
                list.Add(new Kolcsonzes(item));
            }
            Console.WriteLine($"5. feladat: Napi kolcsonzesek szama: {list.Count}");
            //6. feladat
            Console.Write("6. feladat: Kerek egy nevet: ");
            string hatnev = Console.ReadLine();
            bool hat = false;
            Console.WriteLine($"\t{hatnev} kocsonzesei:");
            foreach (var i in list)
            {
                if (i.Nev == hatnev)
                {
                    hat = true;
                    Console.WriteLine($"\t{i.EOra}:{i.EPerc}-{i.VOra}:{i.Vperc}");
                }
            }
            if (hat == false)
            {
                Console.WriteLine("Nem volt ilyen nevu kolcsonzo!");
            }
            //7. feladat
            Console.Write("7. feladat: Adjon meg egy idopontot ora:perc alakban: ");
            string het = Console.ReadLine();
            var oszto = het.Split(":");
            int ElvitelIdejePercben, VisszahozatalIdejePercben, KolcsonzesIdeje;
            Console.WriteLine("\tA vizen levo jarmuvek:");
            foreach (var i in list)
            {
                ElvitelIdejePercben = (i.EOra * 60) + i.EPerc;
                VisszahozatalIdejePercben = (i.VOra * 60) + i.Vperc;
                KolcsonzesIdeje = (int.Parse(oszto[0]) * 60) + int.Parse(oszto[1]);
                if (ElvitelIdejePercben <= KolcsonzesIdeje && VisszahozatalIdejePercben >= KolcsonzesIdeje)
                {
                    Console.WriteLine($"\t{i.EOra}:{i.EPerc}-{i.VOra}:{i.Vperc} : {i.Nev}");
                }
            }
            //8. feladat
            int bevetel = 177600;
            Console.WriteLine($"8. feladat: A napi bevetel: {bevetel} Ft");
            //9. feladat
            var f = list.Where(h => h.JAzon == 'F').ToList();
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\admin\Downloads\F.txt");
            foreach (var i in f)
            {
                streamWriter.WriteLine($"{i.EOra}:{i.EPerc}-{i.VOra}:{i.Vperc} : {i.Nev}");
            }
            streamWriter.Close();
            //10. feladat
            Console.WriteLine("10. feladat: Statisztika");
            var a = list.Where(h => h.JAzon == 'A').ToList();
            var b = list.Where(h => h.JAzon == 'B').ToList();
            var c = list.Where(h => h.JAzon == 'C').ToList();
            var d = list.Where(h => h.JAzon == 'D').ToList();
            var e = list.Where(h => h.JAzon == 'E').ToList();
            var g = list.Where(h => h.JAzon == 'G').ToList();
            Console.WriteLine($"\tA - {a.Count()}");
            Console.WriteLine($"\tB - {b.Count()}");
            Console.WriteLine($"\tC - {c.Count()}");
            Console.WriteLine($"\tD - {d.Count()}");
            Console.WriteLine($"\tE - {e.Count()}");
            Console.WriteLine($"\tF - {f.Count()}");
            Console.WriteLine($"\tG - {g.Count()}");
        }
    }
}