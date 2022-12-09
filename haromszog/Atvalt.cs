using System;

namespace haromszog
{
    static class Atvalt
    {
        const double pi = Math.PI;

        public static double DegToRad(double deg)
        {
            return (pi * deg) / 180;
        }
    }
}
