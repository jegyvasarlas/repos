using System;

namespace MyFurniture
{
    abstract class Furniture
    {
        const double basePrice = 55000;
        public virtual double getPrice() { return basePrice; }
        public virtual string Write() { return "Furniture"; }
    }

    class Table:Furniture
    {
        const double tableFactor = 0.7;
        private int magassag;
        public override double getPrice()
        {
            return base.getPrice() * tableFactor;
        }
        public override string Write()
        {
            return "Table\n Ar: " + getPrice() + "\n Magassag: " + magassag;
        }
    }

    class Bed:Furniture
    {
        const double bedFactor = 2.2;
        private int hossz;
        private int szelesseg;
        public override double getPrice()
        {
            return base.getPrice() * bedFactor;
        }
        public override string Write()
        {
            return "Bed\n Ar: " + getPrice() + "\n Hossz: " + hossz + "\n Szelesseg: " + szelesseg;
        }
    }
    
    class Chair:Furniture
    {
        const double chairFactor = 0.3;
        private int labszam;
        public override double getPrice()
        {
            return base.getPrice() * chairFactor;
        }
        public override string Write()
        {
            return "Chair\n Ar: " + getPrice() + "\n Labszam: " + labszam;
        }
    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            Furniture[] furniture = new Furniture[3];
            furniture[0] = new Table();
            furniture[1] = new Bed();
            furniture[2] = new Chair();
            foreach (Furniture f in furniture)
            {
                Console.WriteLine(f.Write());
            }
        }
    }
}