using System;

namespace linkedlist
{
    class Program
    {
        static void Main()
        {
            LinkedList ll = new LinkedList();

            ll.AddFirst(3);
            ll.AddFirst(9);
            ll.AddFirst(-5);
            ll.AddFirst(11);
            ll.AddFirst(44);

            LinkedList l2 = new LinkedList(10);
            l2.AddFirst(5);
            l2.AddFirst(7);
            l2.AddFirst(123);
            l2.AddFirst(-999);

            ll.WriteLine();
            l2.WriteLine();

            Console.WriteLine("\nAz ll elemszama: "+ll.Count);

            //Console.ReadKey();

            int c = 0;
            for (c = 1; c < 10; c++);
                Console.WriteLine("\n"+c);

            ll.AddLast(28);
            ll.AddLast(12);
            ll.WriteLine();
            Console.WriteLine("\nAz ll elemszama: " + ll.Count);

            //Console.ReadKey();
            Console.WriteLine("Beszuras");
            ll.Add(66, 2);
            ll.WriteLine();

            /*
                for (int i = 0; i < ll.Count; i++)
            
             */

            ll.RemoveFirst();
            ll.WriteLine();

            ll.RemoveLast();
            ll.WriteLine();

            Console.ReadKey();
        }
    }
}
