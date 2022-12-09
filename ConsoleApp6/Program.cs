using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[1000];
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
                tomb[i] = r.Next(int.MinValue, int.MinValue);
            for(int i = 0; i < tomb.Length-1; i++)
            {
                for(int j = i+1; j < tomb.Length; j++)
                {
                    if(tomb[i] == tomb[j])
                    {
                        //novekvobe rendez
                        int tmp = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = tmp;
                        
                        //masik csere ami nem csak szamokra van tmp nelkul

                        /*tomb[i] ^= tomb[j];
                        tomb[j] ^= tomb[i];
                        tomb[i] ^= tomb[j];*/

                    }
                }
            }

            for (int i = 0; i < tomb.Length; i++)
                Console.WriteLine(tomb[i] + " ");
        }
    }
}