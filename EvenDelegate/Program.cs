using System;

namespace EvenDelegate
{
    class Program
    {
        public static void Main(string[] args)
        {
            Alkalmazott jozsi = new Alkalmazott("Kiss József", 350000);
            jozsi.FizetesemelesErtesites += FizetesemelesErtesites;
            Alkalmazott bela = new Alkalmazott("Nagy Béla", 340000);
            bela.FizetesemelesErtesites += FizetesemelesErtesites;
            Alkalmazott sanyi = new Alkalmazott("Tóth Sándor", 480000);
            Alkalmazott piros = new Alkalmazott("Kovács Piroska", 500000);

            jozsi.Fizetes = 360000;
            
            bela.Fizetes = 400000;
            
        }
        
        private static void FizetesemelesErtesites(string uzenet)
        {
            Console.WriteLine(uzenet);
        }
    }
}