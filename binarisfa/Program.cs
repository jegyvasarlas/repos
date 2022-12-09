using System;

namespace binarisfa
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            bt.Add(2);
            bt.Add(7);
            bt.Add(28);
            bt.Add(42);
            bt.Add(-300);
            bt.Add(70);
            bt.Add(71);
            bt.Add(0);
            bt.Add(1);
            bt.Add(3);
            bt.Add(12);
            bt.Add(22);

            bt.InOrder();

            bt.Add(6);
            bt.InOrder();

            bt.Add(2);
            bt.InOrder();

            Console.WriteLine("Binaris fa melysege: " + bt.Depth());

            Console.WriteLine("Melyseg: " + bt.Depth());
            Console.WriteLine("Min: " + bt.MinValue());
            Console.WriteLine("Max: " + bt.MaxValue());
            Console.WriteLine("A 0 elem " + (bt.IsElement(0) ? " benne van" : "nincs benne"));

            BinaryTree bt2 = new BinaryTree(bt);
            bt2.Add(10);
            bt.InOrder();
            bt2.InOrder();


            Console.ReadKey();
        }
    }
}
