using System;

namespace haromszog
{
    class Program
    {
        static void Main(string[] args)
        {
            DerekszoguHaromszog d = new DerekszoguHaromszog(3, 45);
            d.Write();

            Console.ReadKey();
        }
    }
}
