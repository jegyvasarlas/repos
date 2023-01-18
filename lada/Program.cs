using System;
using System.Diagnostics;

namespace lada
{
    class BinSort
    {
        public static void Sort(int[] array)
        {
            int maxVal;
            maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                }
            }
            int[] bin = new int[maxVal + 1];
            for (int i = 0; i < array.Length; i++)
            {
                bin[array[i]]++;
            }
            int idx = 0;
            for (int i = 0; i < bin.Length; i++)
            {
                for (int j = 0; j < bin[i]; j++)
                {
                    array[idx++] = i;
                }
            }
        }
    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            var array = new int[100];
            var random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
            Console.WriteLine("Rendezes elott:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            BinSort.Sort(array);
            sw.Stop();
            Console.WriteLine("Rendezes utan:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Rendezes ideje: " + sw.Elapsed);
            Console.ReadKey();
        }
    }
}