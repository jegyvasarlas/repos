using System;
using System.Linq;

namespace struktura
{
    struct Idopont
    {
        public byte ora;
        public byte perc;
        public byte mp;
    }
    class Program
    {
        static string IdopontKiir(Idopont t)
        {
            return t.ora+":"+t.perc+":"+t.mp;
        }

        static int Idopont2Mp(Idopont t)
        {
            return t.ora * 60 * 60 + t.perc * 60 + t.mp;
        }

        static Idopont Mp2Idopont(int mp)
        {
            Idopont vissza;
            vissza.ora = (byte)(mp / (60 * 60));
            mp -= vissza.ora * 3600;
            vissza.perc = (byte)(mp / 60);
            vissza.mp = (byte)(mp % 60);
            return vissza;

        }

        static Idopont MinMax(Idopont[] ta, bool max)
        {
            int keres = Idopont2Mp(ta[0]);
            for(int i = 1; i < ta.Length; i++)
            {
                int id = Idopont2Mp(ta[i]);
                if (max && id > keres)
                {
                    keres = id;
                }
                else if (!max && id < keres)
                    keres = id;
            }
            return Mp2Idopont(keres);
        }
        
        static int Megszamol(Idopont[] ta, bool delelott)
        {
            int db = 0;
            for (int i = 0; i < ta.Length; i++)
                if (delelott && ta[i].ora < 12)
                    db++;
                else if (!delelott && ta[i].ora >= 12)
                    db++;
            return db;

        }

        static void LegkisebbEltelt(Idopont[] ta, ref Idopont t1, ref Idopont t2)
        {
            int min = Math.Abs(Idopont2Mp(t1) - Idopont2Mp(t2));
            t1 = ta[0];
            t2 = ta[1];
            for (int i=0; i<ta.Length-1; i++)
                for(int j= 0; j<ta.Length; j++)
                {
                    int lok_min = Math.Abs(Idopont2Mp(ta[i]) - Idopont2Mp(ta[j]));
                    if(i!=j && lok_min < min)
                    {
                        t1 = ta[i];
                        t2 = ta[j];
                    }
                }
        }

        static void Rendez(ref Idopont[] ta)
        {
            for (int i = 0; i < ta.Length; i++)
                for (int j = i + 1; j < ta.Length; j++)
                    if (Idopont2Mp(ta[j]) < Idopont2Mp(ta[i]))
                    {
                        Idopont tmp = ta[i];
                        ta[i] = ta[j];
                        ta[j] = tmp;
                    }
        }

        static void Main(string[] args)
        {
            Idopont most;
            most.ora = 7;
            most.perc = 43;
            most.mp = 49;

            Console.WriteLine("A mostani idopont: " + IdopontKiir(most) + "\n");

            Idopont[] idopontok = new Idopont[10];
            Random r = new Random();
            for (int i = 0; i < idopontok.Length; i++)
            {
                idopontok[i].ora = (byte)r.Next(0, 24);
                idopontok[i].perc = (byte)r.Next(0, 60);
                idopontok[i].mp = (byte)r.Next(0, 60);
                Console.WriteLine(IdopontKiir(idopontok[i]));
            }

            Console.WriteLine("\n" + IdopontKiir(idopontok[0]) + " es " + IdopontKiir(idopontok[1]) + " kozott eltelt ido: " + IdopontKiir(Mp2Idopont(Math.Abs(Idopont2Mp(idopontok[0]) - Idopont2Mp(idopontok[1])))));

            // 1.) Határozzuk meg, hogy a tömbben melyik a legkorábbi és a legkésőbbi időpont!
            // 2.) Határozzuk meg, hogy hány időpont van délelőtt, illetve hány délután!
            // 3.) Határozzuk meg, hogy melyik az a két időpont amely között a legkevesebb idő telt el!
            // 4.) Rendezzük a tömböt időpont szerinti növekvő sorrendbe!

            // 1. feladat

            var minora = idopontok.Select(x => x.ora).Min();
            var minperc = idopontok.Where(x => x.ora == minora).Select(x => x.perc).Min();
            var minmp = idopontok.Where(x => x.ora == minora && x.perc == minperc).Select(x => x.mp).Min();

            var maxora = idopontok.Select(x => x.ora).Max();
            var maxperc = idopontok.Where(x => x.ora == maxora).Select(x => x.perc).Max();
            var maxmp = idopontok.Where(x => x.ora == maxora && x.perc == maxperc).Select(x => x.mp).Max();

            //Sajat
            Console.WriteLine();
            Console.WriteLine($"A legkisebb idopont: {minora}:{minperc}:{minmp}");
            Console.WriteLine($"A legnagyobb idopont: {maxora}:{maxperc}:{maxmp}" + "\n");

            //Tanari
            Console.WriteLine("Legkorabbi idopont: " + IdopontKiir(MinMax(idopontok, 1==0)));
            Console.WriteLine("Legkesobbi idopont: " + IdopontKiir(MinMax(idopontok, 1==1)));
            Console.WriteLine();
            
            // 2. feladat

            byte am = 0;
            byte pm = 0;

            foreach (var i in idopontok)
            {
                if (i.ora < 12)
                    am++;
                else if (i.ora >= 12)
                    pm++;
            }

            //Sajat
            Console.WriteLine($"{am} db idopont volt delelott es {pm} db idopont volt delutan\n");

            //Tanari
            Console.WriteLine("Delelotti idopontok szama: " + Megszamol(idopontok, true));
            Console.WriteLine("Delutanii idopontok szama: " + Megszamol(idopontok, true));

            // 3. feladat

            Idopont t1 = idopontok[0];
            Idopont t2 = idopontok[1];

            LegkisebbEltelt(idopontok, ref t1, ref t2);

            Console.WriteLine("A ket idopont amely kozott a legkevesebb ido telt el: \n" + IdopontKiir(t1) + " es " + IdopontKiir(t2));

            // 4. feladat

            Rendez(ref idopontok);
            for (int i = 0; i < idopontok.Length; i++)
                Console.WriteLine(IdopontKiir(idopontok[i]));

            Console.ReadKey();
        }
    }
}
