using System;
using System.Collections.Generic;
using StackFeladat;

namespace Halmaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Set<string> gyumolcsok = new Set<string>();
            gyumolcsok.Add("banan");
            gyumolcsok.Add("eper");
            gyumolcsok.Add("banan");
            gyumolcsok.Add("dinnye");
            gyumolcsok.Add("anananasz");
            gyumolcsok.Add("banan");
            gyumolcsok.Add("alma");
            gyumolcsok.Add("szolo");

            Console.WriteLine(gyumolcsok.ToString());

            Set<string> gy2 = new Set<string>();
            gy2.Add("paradicsom");
            gy2.Add("lime");
            gy2.Add("eper");
            gy2.Add("granatalma");
            gy2.Add("lichi");
            gy2.Add("szolo");
            gy2.Add("banan");

            Set<string> metszet = Set<string>.Intersect(gyumolcsok, gy2);
            Console.WriteLine(metszet.ToString());

            Console.WriteLine(Set<string>.Union(gyumolcsok, gy2).ToString());

            Console.WriteLine(Set<string>.Except(gyumolcsok, gy2).ToString());

            Console.WriteLine();

            Set<Tanulo> tanulok = new Set<Tanulo>();
            tanulok.Add(new Tanulo("Gipsz Jakab", "Okoritofulpos", new DateTime(1989, 02, 02), 73154758896));
            Tanulo t = new Tanulo("Vad Virag", "Budapest", new DateTime(2000, 01, 01), 10000000000);
            tanulok.Add(t);

            Console.WriteLine(tanulok.ToString());

            Console.ReadKey();
        }
    }
}
