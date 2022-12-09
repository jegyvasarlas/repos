using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    interface IEgyik
    {
        void Kiir();
    }

    interface IMasik
    {
        void Kiir();
    }

    class Osztaly: IEgyik, IMasik
    {
        public void Kiir()
        {
            Console.WriteLine("Mukodik!");
        }

        void IEgyik.Kiir()
        {
            Console.WriteLine("Mukodik egyik!");
        }

        void IMasik.Kiir()
        {
            Console.WriteLine("Mukodik masik!");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Osztaly o = new Osztaly();
            o.Kiir();
            ((IEgyik)o).Kiir();
            if(o is IMasik) (o as IMasik).Kiir();

            Console.ReadKey();
        }
    }
}
