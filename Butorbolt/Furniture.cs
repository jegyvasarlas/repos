using System;

namespace Butorbolt
{
    abstract class Furniture
    {
        const double basePrice = 25000;
        public virtual double getPrice() { return basePrice; }
        public virtual string Print()
        {
            return "";
        }
    }
}
