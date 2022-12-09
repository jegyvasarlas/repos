using System;
//using System.Linq;

namespace DinamikusTomb
{
    internal class Program
    {
        static void Hozzafuz(ref int[] tomb, int ujelem)
        {
            int[] tmp = new int[tomb.Length + 1];
            for (int i = 0; i < tomb.Length; i++)
            {
                tmp[i] = tomb[i];
            }
            tmp[tomb.Length] = ujelem;
            tomb = tmp;
        }

        public static int? TorolElso(ref int[] tomb)
        {
            if(tomb.Length == 0)
                return null;

            int vissza = tomb[0];
            int[] tmp = new int[tomb.Length - 1];

            for (int i = 0; i < tmp.Length; i++)
                tmp[i] = tomb[i + 1];
            
            tomb = tmp;
            return vissza;
        }

        public static void TombKiir(ref int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
                Console.Write(tomb[i] + " ");
            Console.WriteLine();
        }
        

        public static int TorolUtolso(ref int[] tomb)
        {
            int vissza = tomb[tomb.Length-1];
            int[] tmp = new int[tomb.Length - 1];
            for (int i = 0; i < tmp.Length; i++)
                tmp[i] = tomb[i];
            tomb = tmp;
            return vissza;
        }

        /*public static void TorolElso(ref int[] tomb)
        {
            tomb = tomb.Skip(1).ToArray();
        }
        public static void TorolUtolso(ref int[] tomb)
        {
            tomb = tomb.Take(tomb.Length - 1).ToArray();
        }*/

        public static int? Torol(ref int[] tomb, int index)
        {
            //tomb = tomb.Take(tomb[index]).ToArray();
            if (index < 0 || index > tomb.Length - 1)
                return null;
            int vissza = tomb[index];
            int[] tmp = new int[tomb.Length - 1];
            for (int i = 0; i < tmp.Length; i++)
                if (i < index)
                    tmp[i] = tomb[i];
                else if (i > index)
                    tmp[i] = tomb[i + 1];
            tomb = tmp;
            return vissza;
        }

        static void Main(string[] args)
        {
            int szam;
            int[] tomb = new int[0];
            while( (szam = int.Parse(Console.ReadLine())) != 0 )
            {
                if(szam > 0)
                    Hozzafuz(ref tomb, szam);
            }
            Console.WriteLine();
            TombKiir(ref tomb);
            Console.WriteLine("---- Elso elem torlese utan ----");
            TorolElso(ref tomb);
            TombKiir(ref tomb);
            Console.WriteLine();
            Console.WriteLine("---- Utolso elem torlese utan ----");
            TorolUtolso(ref tomb);
            TombKiir(ref tomb);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
