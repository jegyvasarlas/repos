using System;

namespace OroklesiTipusok2
{
    class A
    {
        protected int a;
        public A(): this(0) { }
        public A(int x) { a = x; }
        public virtual void Kiir() { Console.WriteLine(a); }
        public void Megjelenit() { Kiir(); }
    }

    class B: A
    {
        protected new int a;
        public B(): this(0, 0) { }
        public B(int x, int y): base(x) { a = y; }
        public override void Kiir()
        {
            base.Kiir();
            Console.WriteLine(a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B beta = new B(7, 29);
            beta.Megjelenit(); // 7, 29

            A mutato = beta;
            mutato.Megjelenit(); // 7, 29

            ((A)beta).Megjelenit(); // 7, 29

            if (beta is A)
                (beta as A).Megjelenit(); // 7, 29

            Console.ReadKey();
        }
    }
}
