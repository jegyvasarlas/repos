using System;

namespace Dec1214
{
    public class Node
    {
        private int data;
        private Node next;
        private List a;
        public int Data
        {
            get { return data; }
        }
        public Node Next
        {
            set { next = value; }
            get { return next; }
        }
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
        
    }

    class List
    {
        public int[] a = new int[0];
        public void Add(int data)
        {
            int[] b = new int[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
            b[a.Length] = data;
            a = b;
        }

    }

    class FesusLista
    {
        int count;
        Node head;
        Node tail;
        public FesusLista()
        {
            count = 0;
            head = null;
            tail = null;
        }
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
            count++;
        }
        public void FesusListaRendezEsKiir()
        {
            Node node = head;
            List a = new List();
            while (node != null)
            {
                a.Add(node.Data);
                node = node.Next;
            }
            int[] b = a.a;
            int temp;
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b.Length - 1; j++)
                {
                    if (b[j] > b[j + 1])
                    {
                        temp = b[j];
                        b[j] = b[j + 1];
                        b[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
        public void Print()
        {
            Node current = head;
            if (head == null)
            {
                Console.WriteLine("Lista ures");
                return;
            }
            while (current != null)
            {
                Console.WriteLine(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            FesusLista lista = new FesusLista();
            lista.Add(66);
            lista.Add(2);
            lista.Add(-12);
            lista.Add(0);
            lista.Add(1);
            lista.Add(33);
            lista.Add(49);
            lista.Add(5);
            lista.Print();
            lista.FesusListaRendezEsKiir();
            
            Console.ReadKey();
        }
    }
}