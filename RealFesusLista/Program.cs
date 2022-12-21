using System;

namespace RealFesusLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FesusLista<string, string> konyvek = new FesusLista<string, string>();
            konyvek.GerincElejereFuz("J. K. Rowling");
            konyvek.GerincElejereFuz("Arany Janos");
            konyvek.GerincElejereFuz("Agatha Cristie");
            konyvek.GerincElejereFuz("Stephen King");
            konyvek.GerincElejereFuz("Reiter Istvan");

            konyvek["Stephen King"].UjElem("Ragyogas");
            konyvek["Stephen King"].UjElem("Az");
            konyvek["J. K. Rowling"].UjElem("Harry Potter es a bolcsek kove");
            konyvek["Reiter Istvan"].UjElem("C# programozas lepesrol lepesre");
            konyvek.PrintAll();
            Console.WriteLine(konyvek[1, 0].ToString());
            Console.WriteLine(konyvek[1, 1].ToString());
            Console.ReadKey();  
        }
        
            
        
        
    }
}
