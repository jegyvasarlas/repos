using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Cseveges
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Beszelgetes> beszelgetesek = new List<Beszelgetes>();
            List<string> tagok = new List<string>();
            foreach (var i in File.ReadAllLines("tagok.txt"))
            {
                tagok.Add(i);
            }
            foreach (var i in File.ReadAllLines("csevegesek.txt").Skip(1))
            {
                beszelgetesek.Add(new Beszelgetes(i));
            }
            // 4. feladat
            Console.WriteLine($"4. feladat: Tagok szama: {tagok.Count}fo - Beszelgetesek: {beszelgetesek.Count}db");
            // 5. feladat
            Console.WriteLine($"5. feladat: Leghosszabb beszelgetes adatai");
            Beszelgetes leghosszabb = beszelgetesek.OrderByDescending(x => x.Veg - x.Kezdet).First();
            Console.WriteLine($"\tKezdemenyezo: {leghosszabb.Kezdemenyezo}");
            Console.WriteLine($"\tFogado: {leghosszabb.Fogado}");
            Console.WriteLine($"\tKezdete: {leghosszabb.Kezdet.ToString("yy.MM.dd-HH:mm:ss")}");
            Console.WriteLine($"\tVege: {leghosszabb.Veg.ToString("yy.MM.dd-HH:mm:ss")}");
            Console.WriteLine($"\tHossz: {(leghosszabb.Veg - leghosszabb.Kezdet).TotalSeconds}mp");
            // 6. feladat
            Console.Write($"6. feladat: Adja meg egy tag nevet: ");
            string tag = Console.ReadLine();
            Console.WriteLine($"\tA beszelgetesek osszes ideje: {new TimeSpan(0, 0, (int)beszelgetesek.Where(x => x.Kezdemenyezo == tag || x.Fogado == tag).Sum(x => (x.Veg - x.Kezdet).TotalSeconds))}");
            // 7. feladat
            Console.WriteLine($"7. feladat: Nem beszelgettek senkivel");
            foreach (var i in tagok.Where(x => !beszelgetesek.Any(y => y.Kezdemenyezo == x || y.Fogado == x)))
            {
                Console.WriteLine($"\t{i}");
            }
            // 8. feladat
            Console.WriteLine($"8. feladat: Leghosszabb csendes időszak 15h-tol");
            DateTime maxCsendKezdete = new DateTime(2021, 9, 27, 15, 0, 0);
            DateTime maxCsendVege = beszelgetesek[0].Kezdet;
            TimeSpan maxCsendHossz = maxCsendVege - maxCsendKezdete;
            DateTime aktCsendVege = beszelgetesek[0].Veg;

            foreach (var b in beszelgetesek.Skip(1))
            {
                if (b.Kezdet > aktCsendVege)
                {
                    TimeSpan aktCsendHossz = b.Kezdet - aktCsendVege;
                    if (aktCsendHossz > maxCsendHossz && b.Kezdet.Hour >= 15)
                    {
                        maxCsendHossz = aktCsendHossz;
                        maxCsendKezdete = aktCsendVege;
                        maxCsendVege = b.Kezdet;
                    }
                }
                if (b.Veg > aktCsendVege) aktCsendVege = b.Veg;
            }
            Console.WriteLine($"\tKezdete: {maxCsendKezdete.ToString("yy.MM.dd-HH:mm:ss")}");
            Console.WriteLine($"\tVége:    {maxCsendVege.ToString("yy.MM.dd-HH:mm:ss")}");
            Console.WriteLine($"\tHossza:  {maxCsendHossz}");

            Console.ReadKey();
        }
    }

    class Beszelgetes
    {
        public DateTime Kezdet { get; private set; }
        public DateTime Veg { get; private set; }
        public string Kezdemenyezo { get; private set; }
        public string Fogado { get; private set; }
        public Beszelgetes(string sor)
        {
            string[] adatok = sor.Split(';');
            Kezdet = DateTime.ParseExact(adatok[0], "yy.MM.dd-HH:mm:ss", CultureInfo.InvariantCulture);
            Veg = DateTime.ParseExact(adatok[1], "yy.MM.dd-HH:mm:ss", CultureInfo.InvariantCulture);
            Kezdemenyezo = adatok[2];
            Fogado = adatok[3];
        }
    }
}