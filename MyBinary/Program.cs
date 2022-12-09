using System;

namespace MyBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBinary mb1 = new MyBinary(11);
            MyBinary mb2 = new MyBinary(11);
            mb1.Kiir();
            mb2.Kiir();
            
            MyBinary mb3 = mb1 + mb2;
            mb3.Kiir();

            //MyBinary mb4 = mb2 - mb1;
            //mb3.Kiir();

            Console.ReadKey();
        }
    }
}
