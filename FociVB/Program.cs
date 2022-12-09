using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace FociVB
{
    class Foci
    {
        public string Fordulo { get; private set; }
        public string Gyoztes { get; private set; }
        public string Vesztes { get; private set; }
        public int GyoztesGolok { get; private set; }
        public int VesztesGolok { get; private set; }

        public Foci(string sor)
        {
            string[] m = sor.Split(',');
            Fordulo = m[0];
            Gyoztes = m[1];
            Vesztes = m[2];
            GyoztesGolok = int.Parse(m[3]);
            VesztesGolok = int.Parse(m[4]);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Foci> foci = new List<Foci>();
            foreach (var item in File.ReadAllLines("data.csv").Skip(1))
            {
                foci.Add(new Foci(item));
            }
            Console.Write("2. Kerek egy csapatnevet: ");
            string ketto = Console.ReadLine();
            int kettoszamlalo = 0;
            foreach (var f in foci)
            {
                if(f.Gyoztes==ketto)
                {
                    kettoszamlalo++;
                }
            }
            Console.WriteLine($"A(z) {ketto} csapat {kettoszamlalo} db meccset nyert");
            var max = foci.Select(a => a.GyoztesGolok).Max();
            var min = foci.Select(a => a.GyoztesGolok).Min();
            Console.WriteLine($"3. A maximalis golkulonbseg: {max-min}");

            //Fordulo,Gyoztes,Vesztes,Gyoztes golok,Vesztes golok
            //A,Oroszorszag,Szaud-Arabia,5,0
            //A,Uruguay,Egyiptom,1,0
            //B,Iran,Marokko,1,0

            int oroszorszag = 0;
            int szaudarabia = 0;
            int uruguay = 0;
            int egyiptom = 0;
            int iran = 0;
            int marokko = 0;

            foreach(var f in foci)
            {
                if (f.Gyoztes == "Oroszorszag") oroszorszag = oroszorszag + 3;
                else if (f.Gyoztes == "Szaud-Arabia") szaudarabia = szaudarabia + 3;
                else if (f.Gyoztes == "Uruguay") uruguay = uruguay + 3;
                else if (f.Gyoztes == "Egyiptom") egyiptom = egyiptom + 3;
                else if (f.Gyoztes == "Iran") iran = iran + 3;
                else if (f.Gyoztes == "Marokko") marokko = marokko + 3;
                // Dontetlen nincs
            }

            Console.WriteLine("Oroszorszag: "+oroszorszag+"pont");
            Console.WriteLine("Szaud-Arabia: " + szaudarabia + "pont");
            Console.WriteLine("Uruguay: " + uruguay + "pont");
            Console.WriteLine("Egyiptom: " + egyiptom + "pont");
            Console.WriteLine("Iran: " + iran + "pont");
            Console.WriteLine("Marokko: " + marokko + "pont");

            Console.ReadKey();

        }
    }
}
