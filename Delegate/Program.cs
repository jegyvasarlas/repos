using System;

namespace Delegate
{
    class Program
    {
        delegate int TestDelegate(int x);
        static public int Pow(int x)
        {
            return (x * x);
        }
        
        static void Main(string[] args)
        {
            TestDelegate dlgt = Pow;
            int result = dlgt(10);
            Console.WriteLine(result);
            
            Console.ReadKey();
        }
    } 
}