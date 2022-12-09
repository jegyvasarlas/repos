using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Egy();
            //Ketto();
            //Harom();
            //Negy();
            //Ot();
            //Hat();
            //Het();
            
        }

        static void Het()
        {
            for (byte i = 1; i <= 10; i++)
            {
                for (byte j= 0; j <= 10; j++)
                {
                    Console.Write("{0,4}", (i*j));
                    
                }
                Console.WriteLine();
            }
        }
        static void Hat() //otthonra atgondolni
        {
            for (byte i=10; i>0; i--)
            {
                for (byte j=0; j<=11; j++)
                {
                    Console.Write(" ");
                    if (j > i)
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Ot()
        {
            for (byte i = 1; i <= 10; i++)
            {
                for (byte j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
        static void Negy()
        {
            for (byte i = 1; i <= 10; i++)
            {
                for (byte j = 1; j <= 10; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
        static void Harom()
        {
            for (short i = 1; i < 500; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine($"{i}, Fizz-Buzz");
                } 
                else if (i % 5 == 0) 
                {
                    Console.WriteLine($"{i}, Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}, Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
           
        }
        static void Ketto()
        {
            for (short i = 5000; i >= 1500; i++)
            {
                if (i % 7 == 0) Console.WriteLine(i + " ");
            }
        }
        static void Egy()
        {
            for (byte i = 0; i < 10; i++)
            {
                Console.WriteLine(i + ": " + (i * i));
            }
        }
    }
}