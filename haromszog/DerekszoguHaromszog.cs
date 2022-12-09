using System;

namespace haromszog
{
    class DerekszoguHaromszog
    {
        double a, b, c;
        double alpha;

        public double C
        {
            set
            {
                if (value > 0)
                    c = value;
                else
                    c = 1;
            }
        }

        public double Alpha
        {
            set
            {
                if(value>0 && value < 90)
                    alpha = value;
                else
                    alpha = 45;
            }
        }

        public DerekszoguHaromszog(double c, double alpha) 
        {
            C = c;
            Alpha = alpha;
 
            a = c * Math.Sin(Atvalt.DegToRad(alpha));
            b = c * Math.Cos(Atvalt.DegToRad(alpha));
        }

        public double Kerulet()
        {
            return a + b + c;
        }

        public double Terulet()
        {
            return (a * b) / 2;
        }

        public void Write()
        {
            Console.WriteLine($"haromszog oldalai {a}, {b}, {c} ");
            Console.WriteLine("Kerulet: " + Kerulet());
            Console.WriteLine("Terulet: " + Terulet());
        }
    }
}
