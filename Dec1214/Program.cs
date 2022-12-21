using System;
using System.Security.Permissions;

namespace Dec1214
{
    class Node
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
        // make list from dynamic array
        int[] a = new int[0];
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
        public void Print(FesusLista lista)
        {
            Node node = lista.head;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            FesusLista lista = new FesusLista();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            Console.ReadKey();
        }
    }
}