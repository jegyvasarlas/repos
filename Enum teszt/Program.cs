using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_teszt
{
    internal class Program
    {   public enum Autok
        {
            Toyota=3,
            Barkas,
            Nissan=9,
            Fiat
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ForegroundColor = (ConsoleColor)5;
            Console.WriteLine("a");
            Autok enautom = Autok.Barkas;
            Console.WriteLine(enautom);
            Console.WriteLine((int)enautom);
            Console.ReadKey();
        }
    }
}
