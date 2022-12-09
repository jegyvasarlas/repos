using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[5];
            int[] tomb2 = new int[] {1, 2, 3, 4, 5};
            tomb[0] = 69587;
            tomb[1] = 2354;
            tomb[2] = -3214;
            tomb[3] = -11111;
            tomb[4] = 919191;
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("A tomb " + (i) + ". eleme: " + tomb[i]);
            }
            Random r = new Random();
            int[] villanyszamlak = new int[100];
            for (int i = 0; i < villanyszamlak.Length; i++)
            {
                villanyszamlak[i] = r.Next(5000, 500000);
            }
            long osszeg = 0;
            for (int i = 0; i < villanyszamlak.Length; i++)
            {
                osszeg += villanyszamlak[i];
            }
            Console.WriteLine("A villanyszamlak osszege: " + osszeg);
            double atlag = (double)osszeg / villanyszamlak.Length;
            Console.WriteLine("A villanyszamlak atlaga: " + atlag);
            int max = villanyszamlak[0];
            for (int i = 1; i < villanyszamlak.Length; i++)
                if (villanyszamlak[i] > max)
                    max = villanyszamlak[i];
            Console.WriteLine("A legdragabb villanyszamla: "+max);
            int min = villanyszamlak[0];
            for (int i = 1; i < villanyszamlak.Length; i++)
                if (villanyszamlak[i] < min)
                    max = villanyszamlak[i];
            Console.WriteLine("A legolcsobb villanyszamla: " + min);
            int db = 0;
            for (int i = 0; i < villanyszamlak.Length; i++)
                if (villanyszamlak[i] < 10000) db++;
            Console.WriteLine("A 10000 ft alatti villanyszamlak szama: "+db);
            bool talalat = false;
            for (int i = 0; i < villanyszamlak.Length && !talalat; i++)
                if (villanyszamlak[i] == 500000) talalat = true;
            Console.WriteLine(talalat?"Van":"Nincs" + " 500000 ft-s szamla");
            int[] uj = new int[villanyszamlak.Length];
            int k = 0;
            for (int i = 0; i < villanyszamlak.Length; i++)
                if (Math.Abs((double)villanyszamlak[i] - atlag) < 10000)
                {
                    uj[k] = villanyszamlak[i];
                    k++;
                }

            for (int i = 0; i < k; i++)
                Console.Write(uj[i] + " ");
            Console.WriteLine();
            Console.ReadKey();
            /*List<int> list = new List<int>();
            for (int i = 0; i < villanyszamlak.Length; i++)
            {
                list.Add(villanyszamlak[i]);
            }
            Console.WriteLine($"A gazdag embernek {list.Sum()} ft-t kellene fizetnie");
            Console.WriteLine($"Az embernek {list.Average()} ft-t fizetnek"); ;
            Console.WriteLine($"A legdragabb villanyszamla {list.Max()} ft");
            Console.WriteLine($"A legolcsobb villanyszamla {list.Min()} ft");
            int a = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (i < 10000) a++;
            }
            Console.WriteLine($"{a} db villanyszamla osszege kevesebb mint 5-jegyu");
            bool b = false;
            //list.Insert(3, 500000);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 500000)
                { 
                    b = true;
                }
            }
            if (b == true)
            {
                Console.WriteLine($"Van 500000 forintos szamla");
            }
            else Console.WriteLine($"Nincs 500000 forintos szamla");*/
            Console.ReadKey();
        }
    }
}