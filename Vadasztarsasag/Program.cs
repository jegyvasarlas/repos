using System;

namespace Vadasztarsasag
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Rabbit();
            animals[1] = new PolarBear();
            animals[2] = new Squirrel();

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i].GetType() + " = " + animals[i].getPrice());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

}