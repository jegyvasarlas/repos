using System;

namespace Butorbolt
{
    class Table:Furniture
    {
        const double tableFactor = 0.3;
        int magassag;
        public override double getPrice()
        {
            return base.getPrice() * tableFactor;
        }
        public override string Print()
        {
            return "tableFactor";
        }
    }
}
