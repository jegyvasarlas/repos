using System;

namespace Tort
{
    class Tort
    {
        int szamlalo;
        int nevezo;

        public Tort(int szamlalo, int nevezo)
        {
            this.szamlalo = szamlalo;
            if (nevezo == 0)
                this.nevezo = 1;
            else
                this.nevezo = nevezo;
            Egyszerusit();
        }

        public Tort(Tort masik)
        {
            this.szamlalo = masik.szamlalo;
            this.nevezo = masik.nevezo;
        }

        private void Egyszerusit()
        {
            for (int i = szamlalo<nevezo?szamlalo:nevezo; i>1; i--)
                if(szamlalo%i==0 && nevezo%i==0)
                {
                    szamlalo /= i;
                    nevezo /= i;
                }
        }

        private static int LNKO(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }

        private static int LKKT(int a, int b)
        {
            return (a * b) / LNKO(a, b);
        }


        public static Tort operator +(Tort a, Tort b)
        {
            int kNevezo = LKKT(a.nevezo, b.nevezo);
            return new Tort(a.szamlalo * (kNevezo / a.nevezo) + b.szamlalo * (kNevezo / b.nevezo), kNevezo);
        }

        public static Tort operator +(Tort a, int b)
        {
            return a + new Tort(b, 1);
        }

        public static Tort operator *(Tort a, Tort b)
        {
            return new Tort(a.szamlalo * b.szamlalo, a.nevezo * b.nevezo);
        }

        public static Tort operator *(Tort a, int b)
        {
            return a * new Tort(b, 1);
        }
        public static Tort operator *(int a, Tort b)
        {
            return b * a;
        }

        public static Tort operator -(Tort a, Tort b)
        {
            return a + (-1) * b;
        }
        public static Tort operator -(Tort a, int b)
        {
            return a + (-1) * b;
        }

        public static Tort Reciprok(Tort t)
        {
            return new Tort(t.nevezo, t.szamlalo);
        }

        public static Tort operator /(Tort a, Tort b)
        {
            return a * Reciprok(b);
        }

        public static Tort operator /(Tort a, int b)
        {
            return a * Reciprok(new Tort(b, 1));
            // return a / new Tort(b, 1);
            // return new Tort(a.szamlalo, a.nevezo * b);
        }

        public static Tort operator /(int a, Tort b)
        {
            return a * Reciprok(b);
        }

        public static bool operator==(Tort a, Tort b)
        {
            return a.szamlalo == b.szamlalo && a.nevezo == b.nevezo;
        }

        public static bool operator!=(Tort a, Tort b)
        {
            return !(a == b);
        }

        public static bool operator>(Tort a, Tort b)
        {
            return a.Ertek() > b.Ertek();
        }

        public static bool operator<(Tort a, Tort b)
        {
            return a.Ertek() < b.Ertek();
        }

        public static bool operator<=(Tort a, Tort b)
        {
            return !(a > b);
        }

        public static bool operator>=(Tort a, Tort b)
        {
            return !(a < b);
        }

        public double Ertek()
        {
            return (double)szamlalo / nevezo;
        }

        public void Kiir()
        {
            Console.WriteLine(szamlalo + "/" + nevezo);
        }
    }
}
