using System;
using System.IO;

namespace teszt_beolvas
{
    struct Lista
    {
        public int elso;
        public string masodik;
    }

    internal class Program
    {
        static void Add(ref Lista[] items, Lista newItems)
        {
            Lista[] tmp = new Lista[items.Length + 1];
            for (int i = 0; i < items.Length; i++)
                items[i] = tmp[i];
            tmp[items.Length] = newItems;
            items = tmp;
        }

        static void FajlBeolvas(ref Lista[] items)
        {
            FileStream fs = new FileStream("C:\\Users\\admin\\source\\repos\\teszt_beolvas\\Properties\\file.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string sor;
            while ((sor = sr.ReadLine()) != null)
            {
                string[] adatok = sor.Split(' ');
                Lista uj;
                uj.elso = int.Parse(adatok[0]);
                uj.masodik = adatok[1];
                Add(ref items, uj);
            }
            sr.Close();
            fs.Close();
        }

        static void Main(string[] args)
        {
            // 1. feladat
            Lista[] lista = new Lista[0];
            FajlBeolvas(ref lista);

            // 2. feladat
            Console.WriteLine("2. feladat");
            Console.WriteLine($"A lista elemeinek szama: {lista.Length}"); 
            
            Console.ReadKey();
        }
    }
}
