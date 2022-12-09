using System;
using System.IO;

namespace erettsegi_0930_pentek
{
    struct Telek
    {
        public bool oldal; // true = paros
        public int hossz;
        public char szin;
        public int hazszam;
    }
    internal class Program
    {
        static void Add(ref Telek[] t, Telek ujTelek)
        {
            Telek[] tmp = new Telek[t.Length + 1];
            for (int i = 0; i < t.Length; i++)
                t[i] = tmp[i];
            tmp[t.Length] = ujTelek;
            t = tmp;
        }

        static void FajlBeolvas(ref Telek[] t)
        {
            FileStream fs = new FileStream("kerites.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string sor;
            int paros = 1;
            int paratlan = 0;
            while ((sor = sr.ReadLine()) != null)
            {
                string[] adatok = sor.Split(' ');
                Telek uj;
                uj.oldal = string.Compare(adatok[0], "0") == 0;
                uj.hossz = int.Parse(adatok[1]);
                
                if (uj.oldal)
                {
                    uj.hazszam = paros * 2;
                    paros++;
                }
                else
                {
                    uj.hazszam = (paratlan * 2) + 1;
                    paratlan++;
                }
                Add(ref t, uj);
            }
            sr.Close();
            fs.Close();
        }

        static Telek[] ParatlanOldal(Telek[] t, bool paritas=true)
        {
            Telek[] paratlan = new Telek[0];
            for (int i = 0; i < t.Length; i++)
                if (paritas && !t[i].oldal)
                    Add(ref paratlan, t[i]);
            else if (!paritas && t[i].oldal)
                    Add(ref paratlan, t[i]);
            return paratlan;
        }

        static int? Feladat4(Telek[] t)
        {
            Telek[] paratlan = ParatlanOldal(t);
            for (int i = 0; i < paratlan.Length - 1; i++)
            {
                if (!(paratlan[i].szin == '#' || paratlan[i].szin == ':'))
                {
                    if (paratlan[i].szin == paratlan[i + 1].szin)
                        return paratlan[i].hazszam;
                }
            }
            return null;

        }

        static char? Feladat5(Telek[] t, int hazszam)
        {
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].hazszam == hazszam)
                {
                    return t[i].szin;
                }
            }
            return null;
        }

        static char? UjSzin(Telek[] t, int hazszam)
        {
            Telek[] egyoldal;
            if (hazszam % 2 == 0)
                egyoldal = ParatlanOldal(t, false);
            else
                egyoldal = ParatlanOldal(t);
            Random r = new Random();
            char ujszin = '#';
            for (int i = 0; i < egyoldal.Length; i++)
            {
                if (egyoldal[i].hazszam == hazszam)
                {
                    bool ujrageneral = true;
                    while (ujrageneral)
                    {
                        if (i == 0 || i == egyoldal.Length - 1)
                        {
                            ujszin = (char)r.Next((int)'A', (int)'Z');
                            if (i == 0 && egyoldal[i].szin == ujszin || egyoldal[i + 1].szin == ujszin)
                                ujrageneral = true;
                            else
                                ujrageneral = false;
                            if (i == egyoldal.Length - 1 && egyoldal[i].szin == ujszin || egyoldal[i - 1].szin == ujszin)
                                ujrageneral = true;
                            else
                                ujrageneral = false;
                        }
                        else
                        {
                            if (egyoldal[i].szin == ujszin || egyoldal[i - 1].szin == ujszin || egyoldal[i + 1].szin == ujszin) ujrageneral = true; else ujrageneral = false;
                        }
                    }

                    return ujszin;

                }

            }
            return null;
        }

        static void Feladat6(Telek[] t)
        {
            Telek paratlan = ParatlanOldal(t);
            FileStream fs = new FileStream("utcakep.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < t.Length; i++)
            {
                int hossz = paratlan[i].hossz;
                for (int j = 0; j < hossz; j++)
                    sw.Write(paratlan[i].szin);
            }
            sw.WriteLine
        }
        static void Main(string[] args)
        {
            // 1. feladat
            Telek[] telkek = new Telek[0];
            FajlBeolvas(ref telkek);

            // 2. feladat
            Console.WriteLine("2. feladat");
            Console.WriteLine("Az eladott telkek szama: " + telkek.Length);

            // 3. feladat
            Console.WriteLine("3. feladat");
            Console.WriteLine("A " + (telkek[telkek.Length - 1].oldal ? "paros" : "paratlan") + " oldalon adtak el az utolso telket. ");
            Console.WriteLine("Az utolso telek hazszama: " + telkek[telkek.Length - 1].hazszam);

            // 4. feladat
            Console.WriteLine("4. feladat");
            Console.WriteLine("A szomszedossal egyezik a kerites szine: " + Feladat4(telkek));

            // 5. feladat
            Console.WriteLine("5. feladat");
            Console.WriteLine("Adjon meg egy hazszamot! ");
            int hazszam = int.Parse(Console.ReadLine());
            Console.WriteLine("A kerites szine / allapota: " + Feladat5(telkek, hazszam));
            Console.WriteLine("Egt lehetseges festesi szin: " + UjSzin(telkek, hazszam));

            Console.ReadKey();
        }
    }
}
