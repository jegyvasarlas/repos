using System;

namespace Allasinterju
{
    //Irjon kódot, amelyben Definiál egy IDoSomething interfészt egy f() metódussal
    //Definiál egy IDoSomethingElse interfészt egy f() és egy g() metódussal.
    //Készítsen egy osztályt, amelyikben implementálja az IDoSomething és az IDoSomethingElse interfészeket úgy, hogy mindegyik metódus kiírja a konzolra a az interfész és a metódus nevét.
    //Készítsen egy példányt az osztályból és hívja meg a metódusait.

    interface IDoSomething
    {
        void f();
    }
    
    interface IDoSomethingElse
    {
        void f();
        void g();
    }
    
    class DoSomething : IDoSomething, IDoSomethingElse
    {
        public void f()
        {
            Console.WriteLine("IDoSomething.f()");
        }
        
        void IDoSomethingElse.f()
        {
            Console.WriteLine("IDoSomethingElse.f()");
        }
        
        public void g()
        {
            Console.WriteLine("IDoSomethingElse.g()");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            DoSomething ds = new DoSomething();
            ds.f();
            ((IDoSomethingElse)ds).f();
            ds.g();
        }
    }
}