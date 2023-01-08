using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10]; // create an array with 10 elements
            Random random = new Random(); // create a random number generator
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100); // fill the array with random numbers ranging from 0 to 100 until its full
            }
            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " "); // print every number in the array
            }
            Console.WriteLine();
            var biggestNumber = (from number in array select number).Max(); // find the biggest number in the array
            Console.WriteLine("Biggest number: " + biggestNumber); // print the biggest number
            Console.ReadKey(); // wait for a key press before exit


        }
    }
}
