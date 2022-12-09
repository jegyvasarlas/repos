namespace ConsoleApp
{
    class Program
    {
        static void TombKiir(int[] t)
        {
            Console.WriteLine();
            for (int i = 0; i < t.Length; i++)
                Console.Write(t[i] + " ");
            Console.WriteLine();
        }
        static void Main()
        {
            int[] tomb = new int[300];
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-100, 601);
            }
            Console.WriteLine("Rendezes elott:");
            TombKiir(tomb);
            //-------------------------
            for (int i = 0; i < tomb.Length; i++)
            {
                int index = i;
                for (int j = i+1; j < tomb.Length; j++)
                {
                    if(tomb[j] < tomb[index])
                    {
                        index = j;
                    }
                }
                if (index != i)
                {
                    int tmp = tomb[index];
                    tomb[index] = tomb[i];
                    tomb[i] = tmp;
                }
            }
            Console.WriteLine("\n\nRendezes utan:");
            TombKiir(tomb);
            //-------------------------
            for (int i = 1; i < tomb.Length; i++) 
            {
                for (int j = i; j > 0 && tomb[j] > tomb[j - 1]; j--)
                {
                    int tmp = tomb[j];
                    tomb[j] = tomb[j - 1];
                    tomb[j - 1] = tmp;
                }
            }
            Console.WriteLine("\n\nCsokkeno beszurasos rendezes utan:");
            TombKiir(tomb);
            //-------------------------

        }
    }
}