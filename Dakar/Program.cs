using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dakar
{
    public struct Eredmeny
    {
        public string orszag;
        public int nyert;
        public Eredmeny(string orszag, int nyert)
        {
            this.orszag = orszag;
            this.nyert = nyert;
        }

        public static bool operator >(Eredmeny e1, Eredmeny e2)
        {
            return e1.nyert > e2.nyert;
        }

        public static bool operator <(Eredmeny e1, Eredmeny e2)
        {
            return e1.nyert < e2.nyert;
        }
    }
    class Program
    {
        public static List<Verseny> Fajlbeolvas()
        {
            List<Verseny> versenyek = new List<Verseny>();
            FileStream fs = new FileStream("dakar.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();
            String sor;
            while((sor = sr.ReadLine()) != null)
            {
                string[] egysor = sor.Split(';');
                int ev = int.Parse(egysor[0]);

                string autoOrszag = egysor[1].Substring(0, egysor[1].IndexOf(' '));
                string autoNev = egysor[1].Substring(egysor[1].IndexOf(' ') + 1);

                versenyek.Add(new Verseny(ev, Jarmu.auto, autoNev, autoOrszag, egysor[2]));

                string motorOrszag = egysor[3].Substring(0, egysor[3].IndexOf(' '));
                string motorNev = egysor[3].Substring(egysor[3].IndexOf(' ') + 1);

                versenyek.Add(new Verseny(ev, Jarmu.motor, motorNev, motorOrszag, egysor[4]));

                string kamionOrszag = egysor[5].Substring(0, egysor[5].IndexOf(' '));
                string kamionNev = egysor[5].Substring(egysor[5].IndexOf(' ') + 1);

                versenyek.Add(new Verseny(ev, Jarmu.kamion, kamionNev, kamionOrszag, egysor[6]));

            }
            sr.Close();
            fs.Close();

            return versenyek;
        }

        public static void Feladat9(List<Verseny> v)
        {
            Dictionary<string, int> eredmenyek = new Dictionary<string, int>();
            for(int i = 0; i < v.Count; i++)
            {
                if (eredmenyek.ContainsKey(v[i].orszag))
                {
                    eredmenyek[v[i].orszag]++;
                } 
                else
                {
                    eredmenyek.Add(v[i].orszag, 1);
                }
            }
            List<Eredmeny> eLista = new List<Eredmeny>();
            foreach (KeyValuePair<string,int> kv in eredmenyek)
            {
                eLista.Add(new Eredmeny(kv.Key, kv.Value));
            }

            for(int i=0; i<eLista.Count; i++)
            {
                for(int j=i+1; j<eLista.Count; j++)
                {
                    if (eLista[j] < eLista[i])
                    {
                        Eredmeny tmp = eLista[i];
                        eLista[i] = eLista[j];
                        eLista[j] = tmp;
                    }
                }
            }

            for (int i = eLista.Count - 1; i >= 0; i--)
            {
                if (eLista[i].nyert > 5)
                    Console.WriteLine(eLista[i].orszag + ": " + eLista[i].nyert);
            }

        }


        static void Main(string[] args)
        {
            List<Verseny> versenyek = Fajlbeolvas();
            Feladat9(versenyek);

            Console.ReadKey();
            
        }
    }
}
