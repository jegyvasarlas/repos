 using System;

namespace teglatest
{
    class Program
    {
        static void Tesztelo()
        {
            Teglatest t1 = new Teglatest();
            Teglatest t2 = new Teglatest(3, 29);
            Teglatest t3 = new Teglatest(2, 99);
            Teglatest t4 = new Teglatest(1, 2.5, 3);
        }
        static void Main(string[] args)
        {
            //Tesztelo();
            List lista = new List();
            lista.Add(23);
            lista.Add(19);
            lista.Add(-6);
            lista.Add(42);
            lista.RemoveValue(19);
            for (int i = 0; i < lista.Count; i++)
                Console.WriteLine(lista[i]);

            Console.ReadKey();
        }
    }

    class Teglatest
    {
        double a;
        double b;
        double c;
        
        private double SetOldal(double oldal)
        {
            if (oldal >= 0)
                return oldal;
            return 1;
        }

        public Teglatest() 
        {
            a = b = c = 1;
        }
        // kocka
        public Teglatest(double a) 
        {
            this.a = b = c = SetOldal(a);
        }
        // negyzet alapu hasab
        public Teglatest(double a, double b) 
        {
            this.a = c = SetOldal(a);
            this.b = SetOldal(b);
        }
        public Teglatest(double a, double b, double c) 
        {
            this.a = SetOldal(a);
            this.b = SetOldal(b);
            this.c = SetOldal(c);
        }

    }
}
