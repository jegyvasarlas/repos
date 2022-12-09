using System;

namespace Butorbolt
{
    class Bed:Furniture
    {
        const double bedFactor = 2.4;
        int hossz;
        int szelesseg;
        public override double getPrice()
        {
            return base.getPrice() * bedFactor;
        }
        public override string Print()
        {
            return "bedFactor";
        }
    }
}
