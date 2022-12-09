using System;

namespace OroklesiTipusok1
{
    class A
    {
        protected int a;
        //public A() { a = 0; }
        public A(): this(0) { }
        public A(int x) { a = x; }
        public void Kiir() { Console.WriteLine(a); }
        public void Megjelenit() { Kiir(); }
    }

    // korai kotes = early binding
    class B: A
    {
        protected new int a;
        public B(): this(0, 0) { }
        public B(int x, int y): base(x) { a = y; }
        public new void Kiir()
        {
            base.Kiir();
            Console.WriteLine(this.a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A alfa = new A(12);
            alfa.Megjelenit(); // 12

            B beta = new B(7, 29);
            beta.Megjelenit(); // 7

            if(beta is B)
                (beta as B).Megjelenit(); // 7

            ((B)beta).Megjelenit(); // 7

            A mutato = beta; // referencia masolas
            object o = beta; // osreferencia egy leszarmazottra

            if (o is B)
                (o as B).Megjelenit(); // 7

            object[] tomb = new object[] { 3, "alma", 'v', new B(1, 3) };

            Console.ReadKey();
        }
    }
}
