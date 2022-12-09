using System;
using System.IO;

namespace tarsalgo
{
    struct Athaladas
    {
        public int ora;
        public int perc;
        public int azon;
        public bool irany;
    }

    internal class Program
    {
        static void Add(ref Athaladas[] a, Athaladas uj)
        {
            Athaladas[] tmp = new Athaladas[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
                tmp[i] = a[i];
            tmp[a.Length] = uj;
            a = tmp;
        }

        static void FajlBeolvas(ref Athaladas[] a)
        {
            FileStream fs = new FileStream("ajto.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string sor;
            while((sor=sr.ReadLine()) != null)
            {
                string[] adatok = sor.Split(' ');
                Athaladas uj;
                uj.ora = int.Parse(adatok[0]);
                uj.perc = int.Parse(adatok[1]);
                uj.azon = int.Parse(adatok[2]);
                uj.irany = string.Compare(adatok[3], "be") == 0 ? true : false;
                Add(ref a, uj);
            }

            sr.Close();
            fs.Close();
        }

        static int? UtolsoKilepo(Athaladas[] a)
        {
            for (int i = a.Length - 1; i >= 0; i--)
                if (!a[i].irany)
                    return a[i].azon;
            return null;
        }

        static int[] AthaladasokSzama(Athaladas[] a)
        {
            int[] szamossag = new int[101];
            for(int i = 0; i< szamossag.Length; i++)
                szamossag[i] = 0;
            for (int i = 0; i < a.Length; i++)
                szamossag[a[i].azon]++;
            return szamossag;
        }

        static void FajlbaIras(Athaladas[] a)
        {
            FileStream fs = new FileStream("athaladas.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            int[] szamossag = AthaladasokSzama(a);
            for (int i = 0; i < szamossag.Length; i++)
                if (szamossag[i] > 0)
                    sw.WriteLine(i + " " +szamossag[i]);
            sw.Close();
            fs.Close();
        }

        static string BentMaradtak(Athaladas[] a)
        {
            int[] szamossag = AthaladasokSzama(a);
            string vissza = "";
            for (int i = 0; i < szamossag.Length; i++)
                if (szamossag[i] % 2 == 1)
                    vissza += i + " "; ;
            return vissza;
        }

        static Athaladas LegtobbenBent(Athaladas[] a)
        {
            int max = 0;
            int bentvannak = 0;
            Athaladas vissza = a[0];
            for (int i=0; i < a.Length; i++)
            {
                bentvannak += a[i].irany ? 1 : -1;
                if (bentvannak > max)
                {
                    max = bentvannak;
                    vissza = a[i];
                }
            }
            return vissza;
        }

        static void Feladat7(Athaladas[] a, int azon)
        {
            for (int i = 0; i < a.Length; i++)
                if(a[i].azon == azon)
                {
                    if (a[i].irany)
                        Console.WriteLine(a[i].ora.ToString().PadLeft(2, '0') + ":" + a[i].perc.ToString().PadLeft(2,'0'));
                }
        }

        static int Idopont2Perc(Athaladas at)
        {
            return at.ora * 60 + at.perc;
        }

        static int Feladat8(Athaladas[] a, int azon, ref int kiment)
        {
            int bentvolt = 0;
            int bement = -1;
            kiment = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].azon == azon)
                {
                    if (a[i].irany)
                        bement = Idopont2Perc(a[i]);
                    else
                    {
                        kiment = Idopont2Perc(a[i]);
                        bentvolt += kiment - bement;

                        bement = 0;
                        kiment = 0;
                    }
                }
            }

            if (bement !=0 && kiment == 0)
            {
                kiment = 15 * 60;
                bentvolt += kiment - bement;
                kiment = -1;
            }

            return bentvolt;
        }


        static void Main(string[] args)
        {
            // 1. feladat
            Athaladas[] athaladasok = new Athaladas[0];
            FajlBeolvas(ref athaladasok);

            // 2. feladat
            Console.WriteLine("\n2. feladat");
            Console.WriteLine("Az elso belepo: " + athaladasok[0].azon);
            Console.WriteLine("Az utolso kilepo: " +UtolsoKilepo(athaladasok));

            // 3. feladat
            FajlbaIras(athaladasok);

            // 4.feladat
            Console.WriteLine("\n4. feladat");
            Console.WriteLine("A vegen a tarsalgoban voltak: " + BentMaradtak(athaladasok));

            // 5. feladat
            Console.WriteLine("\n5. feladat");
            Athaladas legtobb = LegtobbenBent(athaladasok);
            Console.WriteLine("Peldaul " + legtobb.ora.ToString().PadLeft(2, '0') + ":" + legtobb.perc.ToString().PadLeft(2,'0') + " -kor voltak a legtobben a tarsalgoban.");

            // 6. feladat
            Console.WriteLine("\n6. feladat");
            Console.Write("Adja meg a szemely azonositojat!");
            int azonosito = int.Parse(Console.ReadLine());

            // 7. feladat
            Console.WriteLine("\n7. feladat");
            Feladat7(athaladasok, azonosito);

            // 7. feladat
            Console.WriteLine("\n8. feladat");
            int kiment = 0;
            int bentvolt = Feladat8(athaladasok, azonosito, ref kiment);
            Console.WriteLine("A(z) "+azonosito+".szemely osszesen "+bentvolt+" percet volt bent, a megfigyeles vegen "+(kiment!=1?"nem volt bent":"a tarsalgoban volt."));

            Console.ReadKey();
        }
    }
}
