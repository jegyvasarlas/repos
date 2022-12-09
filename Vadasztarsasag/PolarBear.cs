using System;

namespace Vadasztarsasag
{
    class PolarBear:Animal
    {
        const double polarBearFactor = 2.4;
        public override double getPrice()
        {
            return base.getPrice() * polarBearFactor;
        }
        public override string GetType()
        {
            return "polarBearFactor";
        }
    }
}
