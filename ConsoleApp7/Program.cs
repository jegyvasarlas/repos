using System;

namespace KivalasztasosRendezes
{
    class Program
    {
        static void Main(string[] args)
        {
            //KivalasztasosRendezes();
            BeszurasosRendezes();
            //PeldaBeszurasosRendezes();
        }

        static void BeszurasosRendezes()
        {
            short[] tomb = new short[10];
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = (short)r.Next(-10, 10);
            }
            for (int i = 1; i < tomb.Length; i++)
            {
                for(int j=i; j>0 && tomb[j] < tomb[j-1]; j--)
                {
                    short tmp = tomb[j];
                    tomb[j] = tomb[j-1];
                    tomb[j-1] = tmp;
                }
            }
            for (int i = 0; i < tomb.Length; i++)
                Console.Write(tomb[i] + " ");
        }

        static void PeldaBeszurasosRendezes()
        {
            var tomb = new int[20];
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20, 20);
            }

            Console.WriteLine("Rendezés előtt:");
            TombKiir(tomb);

            Console.WriteLine("Beszúró rendezés:");
            var beszur = Beszurorendez(tomb);
            TombKiir(beszur);

            Console.ReadKey();
        }

        static void TombKiir(int[] tomb)
        {
            foreach (var elem in tomb)
            {
                Console.Write("{0,4} ", elem);
            }
            Console.WriteLine();
        }

        public static int[] Beszurorendez(int[] bemenet)
        {
            int[] tomb2 = new int[bemenet.Length];
            Array.Copy(bemenet, tomb2, bemenet.Length);
            for (var i = 0; i < tomb2.Length - 1; i++)
            {
                var j = i + 1;
                while (j > 0)
                {
                    if (tomb2[j - 1] > tomb2[j])
                    {
                        var temp = tomb2[j - 1];
                        tomb2[j - 1] = tomb2[j];
                        tomb2[j] = temp;
                    }
                    j--;
                }
            }
            return tomb2;
        }

        static void KivalasztasosRendezes()
        {
            //KivalasztasosRendezes
            short[] tomb = new short[100];
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = (short)r.Next(short.MinValue, short.MaxValue);
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                int index = i;
                for (int j = i + 1; j < tomb.Length; j++)
                {
                    if (tomb[j] < tomb[index])
                    {
                        index = j;
                    }
                }
                if (index != i + 1)
                {
                    short tmp = tomb[index];
                    tomb[index] = tomb[i];
                    tomb[i] = tmp;
                }
            }
            for (int i = 0; i < tomb.Length; i++)
                Console.Write(tomb[i] + " ");
        }
    }
}