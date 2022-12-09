using System;

namespace Allatok
{
    interface IAllat
    {
        void Eszik();
    }

    interface IEmlos: IAllat
    {
        void Mozog();
    }

    interface IKutya: IEmlos
    {
        void Ugat();
    }
    
    class Kutya: IKutya
    {
        public void Eszik()
        {
            Console.WriteLine("A kutya eszik");
        }

        public void Mozog()
        {
            Console.WriteLine("A kutya mozog");
        }

        public void Ugat()
        {
            Console.WriteLine("Vau");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kutya buksi = new Kutya();
            buksi.Eszik();
            buksi.Mozog();

            IEmlos emlos = buksi;
            emlos.Mozog();

            if(emlos is Kutya)
                (emlos as Kutya).Eszik();

            IAllat allat = new Kutya();
            IKutya morzsi = new Kutya();

            Console.ReadKey();
        }
    }
}
