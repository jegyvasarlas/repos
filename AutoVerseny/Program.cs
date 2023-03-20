using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AutoVerseny
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Verseny> versenyek = new List<Verseny>();
            foreach (var sor in File.ReadAllLines("autoverseny.csv").Skip(1))
            {
                versenyek.Add(new Verseny(sor));
            }
            Console.WriteLine($"3. feladat: {versenyek.Count}");
            var FurgeFerencGranPrixCircuitHarmadikKorHanyMpAlatt = versenyek
                .Where(x => x.Versenyzo == "Fürge Ferenc" && x.Palya == "Gran Prix Circuit" && x.Kor == 3)
                .Select(x => x.TotalSecond)
                .First();
            Console.WriteLine($"4. feladat: {FurgeFerencGranPrixCircuitHarmadikKorHanyMpAlatt} másodperc");
            string nev = "";
            Console.WriteLine("5. feladat:\nKérem a versenyző nevét!");
            nev = Console.ReadLine();
            try
            {
                var BekertNevHolEsMennyiIdoAlattFutottaLeALeggyorsabbKoret = versenyek
                    .Where(x => x.Versenyzo == nev)
                    .OrderBy(x => x.TotalSecond)
                    .First();
                Console.WriteLine($"6. feladat: {BekertNevHolEsMennyiIdoAlattFutottaLeALeggyorsabbKoret.Palya}, {BekertNevHolEsMennyiIdoAlattFutottaLeALeggyorsabbKoret.Korido}");
            }
            catch (Exception)
            {
                Console.WriteLine("6. feladat: Nincs ilyen versenyző az állományban!");
            }
            Console.ReadKey();
        }
    }

    class Verseny
    {
        public string Csapat { get; private set; }
        public string Versenyzo { get; private set; }
        public int Eletkor { get; private set; }
        public string Palya { get; private set; }
        public string Korido { get; private set; }
        public int Kor { get; private set; }
        public int Hour { get; private set; }
        public int Minute { get; private set; }
        public int Second { get; private set; }
        public int TotalSecond { get; private set; }
        public Verseny(string sor)
        {
            string[] adatok = sor.Split(';');
            Csapat = adatok[0];
            Versenyzo = adatok[1];
            Eletkor = int.Parse(adatok[2]);
            Palya = adatok[3];
            Korido = adatok[4];
            Kor = int.Parse(adatok[5]);
            Hour = int.Parse(Korido.Split(':')[0]);
            Minute = int.Parse(Korido.Split(':')[1]);
            Second = int.Parse(Korido.Split(':')[2]);
            TotalSecond = Hour * 3600 + Minute * 60 + Second;
        }
    }
}
