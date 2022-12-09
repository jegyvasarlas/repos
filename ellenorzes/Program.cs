using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ellenorzes
{
    class Ellenorzes
    {
        public string Rendszam { get; private set; }
        public int ElejeOra { get; private set; }
        public int ElejePerc { get; private set; }
        public int ElejeMp { get; private set; }
        public int ElejeMpE { get; private set; }
        public int VegeOra { get; private set; }
        public int VegePerc { get; private set; }
        public int VegeMp { get; private set; }
        public int VegeMpE { get; private set; }
        public long EltoltottIdoE { get; private set; }
        public long EltoltottOra { get; private set; }
        public long EltoltottPerc { get; private set; }
        public long EltoltottMp { get; private set; }
        public long EltoltottMpE { get; private set; }
        public long Atlag { get; private set; }

        public Ellenorzes(string sor)
        {
            string[] m = sor.Split(' ');
            Rendszam = m[0];
            ElejeOra = int.Parse(m[1]);
            ElejePerc = int.Parse(m[2]);
            ElejeMp = int.Parse(m[3]);
            ElejeMpE = int.Parse(m[4]);
            VegeOra = int.Parse(m[5]);
            VegePerc = int.Parse(m[6]);
            VegeMp = int.Parse(m[7]);
            VegeMpE = int.Parse(m[8]);
            EltoltottOra = long.Parse(m[5]) - long.Parse(m[1]);
            EltoltottPerc = long.Parse(m[6]) - long.Parse(m[2]);
            EltoltottMp = long.Parse(m[7]) - long.Parse(m[3]);
            EltoltottMpE = long.Parse(m[8]) - long.Parse(m[4]);
            EltoltottIdoE = EltoltottMpE + EltoltottMp * 1000 + EltoltottPerc * 60000 + EltoltottOra * 3600000;
            Atlag = 10 * 3600 * 1000 / EltoltottIdoE;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 2. feladat
            List <Ellenorzes> list = new List<Ellenorzes>();
            foreach (var item in File.ReadAllLines("meresek.txt"))
            {
                list.Add(new Ellenorzes(item));
            }
            Console.WriteLine($"2. feladat\nA meres soran {list.Count} jarmu adatait rogzitettek.");

            // 3. feladat
            int hanyAutoHaladtEl9OraElott = 0;
            foreach (var i in list)
                if (i.VegeOra < 9) hanyAutoHaladtEl9OraElott++;
            Console.WriteLine($"3. feladat\n9 ora elott {hanyAutoHaladtEl9OraElott} jarmu haladt el a vegponti meronel");

            // 4. feladat
            Console.WriteLine("4. feladat");
            Console.Write("Adjon meg egy ora es perc erteket: ");
            string oraPercErtek = Console.ReadLine();
            string[] oraPercErtekTomb = oraPercErtek.Split(' ');
            int oraErtek;
            int percErtek;
            oraErtek = int.Parse(oraPercErtekTomb[0]);
            percErtek = int.Parse(oraPercErtekTomb[1]);
            int hanyAutoHaladtElAMegadottOraPercErtekben = 0;
            /*foreach (var x in list)
            {
                if ()
                {
                    hanyAutoHaladtElAMegadottOraPercErtekben++;
                }
            }
            Console.WriteLine(hanyAutoHaladtElAMegadottOraPercErtekben);*/

            // 5. feladat
            var maxspeed = list
                .Select(x => x.Atlag)
                .Max();

            var rendszam = list
                .Where(x => x.Atlag == maxspeed)
                .Select(x => x.Rendszam)
                .First();

            Console.WriteLine($"5. feladat:\nA legnagyobb sebesseggel halado jarmu:\n\trendszama: {rendszam}\n\tatlagsebessege: {maxspeed} km/h");

            // 6. feladat
            int db = 0;
            foreach (var i in list)
            {
                if (i.Atlag > 90)
                    db++;
            }

            double valami = (double)db*100/list.Count;

            Console.WriteLine($"6. feladat:\nA jarmuvek {Math.Round(valami, 2)}%-a volt gyorshajto.");

            Console.ReadKey();
        }
    }
}
