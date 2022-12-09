using System;

namespace Butorbolt
{
    class Program
    {
        static void Main(string[] args)
        {
            Furniture[] furnitures = new Furniture[3];
            furnitures[0] = new Table();
            furnitures[1] = new Bed();
            furnitures[2] = new Chair();

            for (int i = 0; i < furnitures.Length; i++)
            {
                Console.WriteLine(furnitures[i].Print() + " = " + furnitures[i].getPrice());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

}