using System;
using Osztalyok;

namespace oop_teszt_10_03
{
    class Program
    {
        static void Main()
        {
            Cim c1 = new Cim(1222, "Budapest", "Kozgazdasz", 23);
            Ember bela = new Ember("Kiss Bela", 29, true, "lakatos", c1);
            /*bela.SetEletkor(19);
            Console.WriteLine($"{bela.GetEletkor()}");
            bela.Eletkor = 22;
            Console.WriteLine($"{bela.Eletkor}");*/
            bela.Kiir();
            //c1.Iranyitoszam = 3699;
            //bela.Kiir();
            //bela.Cim = new Cim(); -> Fajdalmas
            bela.Cim.Iranyitoszam = 1313;
            //bela.Kiir();
            bela.SetIranyitoszam(1314);
            //bela.Kiir();
            Console.ReadKey();
        }
    }
}
