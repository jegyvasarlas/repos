using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApplication3
{
    class Kolcsonzesek
    {
        public string Nev { get; private set; }
        public char JAzon { get; private set; }
        public int EOra { get; private set; }
        public int EPerc { get; private set; }
        public int VOra { get; private set; }
        public int VPerc { get; private set; }

        public Kolcsonzesek(string sor)
        {
            string[] adatok = sor.Split(';');
            Nev = adatok[0];
            JAzon = adatok[1][0];
            EOra = int.Parse(adatok[2]);
            EPerc = int.Parse(adatok[3]);
            VOra = int.Parse(adatok[4]);
            VPerc = int.Parse(adatok[5]);
        }
    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            List<Kolcsonzesek> kolcsonzesek = new List<Kolcsonzesek>();
            foreach (var a in File.ReadLines("kolcsonzesek.txt").Skip(1))
            {
                kolcsonzesek.Add(new Kolcsonzesek(a));
            }
            Console.WriteLine(kolcsonzesek.Count);
        }
    }
}