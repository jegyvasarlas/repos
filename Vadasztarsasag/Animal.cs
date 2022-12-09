using System;

namespace Vadasztarsasag
{
    abstract class Animal
    {
        const double basePrice = 100000;
        public virtual double getPrice() { return basePrice; }
        public new virtual string GetType()
        {
            return "";
        }
    }
}
