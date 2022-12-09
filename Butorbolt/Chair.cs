using System;

namespace Butorbolt
{
    class Chair:Furniture
    {
        const double chairFactor = 1.2;

        const int legs = 4;
        public override double getPrice()
        {
            return base.getPrice() * chairFactor;
        }
        public override string Print()
        {
            return $"Chair legs: {legs} chairFactor";
        }
    }
}
