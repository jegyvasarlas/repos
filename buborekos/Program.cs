using System;

namespace buborekos
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[100000];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }
            Console.WriteLine("Rendezes..");
            DateTime start = DateTime.Now;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            DateTime end = DateTime.Now;
            Console.WriteLine("Rendezes vege");
            Console.WriteLine("Ido: {0}", end - start);
            Console.ReadLine();
            
        }
    }
}