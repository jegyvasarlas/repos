using System;

namespace StackFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s1 = new Stack<int>();
            s1.Push(9);
            s1.Push(12);
            s1.Push(1);
            s1.Push(5);
            s1.Push(8);

            for (int i = 0; i < s1.Count; i++)
                Console.Write(s1[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Pop: " + s1.Pop());
            Console.WriteLine("Pop: " + s1.Pop());
            Console.WriteLine("Pop: " + s1.Pop());

            for (int i = 0; i < s1.Count; i++)
                Console.Write(s1[i] + " ");
            Console.WriteLine();

            s1.Pop();
            s1.Pop();
            s1.Pop();
            s1.Pop();
            s1.Pop();
            s1.Pop();

            Console.WriteLine("s1 Ures-e: " + s1.IsEmpty);

            Stack<char> s2 = new Stack<char>();
            s2.Push('T');
            s2.Push('m');
            s2.Push('!');
            s2.Push('5');
            s2.Push('ж');

            Stack<char> s3 = new Stack<char>(s2);
            s2.Clear();
            Console.WriteLine("s2 Ures-e: " + s2.IsEmpty);

            for (int i = 0; i < s3.Count; i++)
                Console.Write(s3[i] + " ");
            Console.WriteLine();
            
            // -.-.-.-.-.-.-.-.-.-.-.

            Stack<Tanulo> tanulok = new Stack<Tanulo>();
            tanulok.Push(new Tanulo("Gipsz Jakab", "Okoritofulpos", new DateTime(1989, 02, 02), 73154758896));
            Tanulo t = new Tanulo("Vad Virag", "Budapest", new DateTime(2000, 01, 01), 10000000000);
            tanulok.Push(t);

            Console.ReadKey();
        }
    }
}
