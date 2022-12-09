using System;

namespace Vadasztarsasag
{
    class Squirrel:Animal
    {
        const double squirrelFactor = 1.2;
        public override double getPrice()
        {
            return base.getPrice() * squirrelFactor;
        }
        public override string GetType()
        {
            return "squirrelFactor";
        }
    }
}
