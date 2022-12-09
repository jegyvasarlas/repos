using System;

namespace OroklesAlapok
{
    class A
    {
        protected int a;
        public A() { }
        public A(int a)
        {
            this.a = a;
        }
    }

    class B: A
    {
        protected new int a;
        protected int b;
        public B(): base() { }
        public B(int a, int b): base(a)
        {
            this.b = b;
        }
        public int A
        {
            get
            { 
                return a;
            }
        }
    }

    sealed class X
    {
        public X() { }

    }

    //class Y: X { }
    //sealed class pl String osztaly

    partial class Valami
    {
        protected int barmi;
    }

    class Program
    {
        static void Main(string[] args)
        {
            B valami = new B(2, 5);
            
        }
    }
}
