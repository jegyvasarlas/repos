using System;
using System.Security.Authentication.ExtendedProtection;
using System.Text.RegularExpressions;

namespace MyBinary
{
    class MyBinary
    {
        long binarisSzam;
        decimal decimalisSzam;

        public MyBinary(long binarisSzam)
        {
            Regex regex = new Regex(@"\b[01]+\b");
            Match match = regex.Match(binarisSzam.ToString());
            if (match.Success)
            {
                this.binarisSzam = binarisSzam;
            }
            else
            {
                throw new Exception("A szamnak binarisnak kell lennie: " + binarisSzam);
            }
        }

        public static MyBinary operator +(MyBinary a, MyBinary b)
        {
            return new MyBinary(a.binarisSzam + b.binarisSzam);
        }

        /*public static MyBinary operator -(MyBinary a, MyBinary b)
        {
            return new MyBinary(a.binarisSzam - b.binarisSzam);
        }*/

        private void ToDecimal()
        {
            decimalisSzam = Convert.ToInt32(binarisSzam.ToString(), 2);
        }

        public void Kiir()
        {
            ToDecimal();
            Console.WriteLine($"Bin: {binarisSzam} Dec: {decimalisSzam}");
        }

    }
}
