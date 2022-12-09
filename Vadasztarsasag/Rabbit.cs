using System;

namespace Vadasztarsasag
{
    class Rabbit:Animal
    {
        const double rabbitFactor = 0.3;
        public override double getPrice()
        {
            return base.getPrice() * rabbitFactor;
        }
        public override string GetType()
        {
            return "rabbitFactor";
        }
    }
}
