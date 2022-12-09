using System;
using System.Collections.Generic;
            
namespace linkedlist
{           
    class LinkedList
    {       
        Node head;
        public LinkedList()
        {   
            head = null;
        }   
            
        public int Count
        {   
            get 
            {
                int count = 0;
                for (Node n = head; n != null; n = n.Next, count++);
                return count;
            }
        }   
            
        public LinkedList(int data)
        {   
            head = new Node(data);
        }   
            
        public void AddFirst(int newData)
        {   
            Node newNode = new Node(newData);
            newNode.Next = head;
            head = newNode;
        }   
            
        public void AddLast(int newData)
        {   
            Node newNode = new Node(newData);
            Node n;
            for (n = head; n.Next != null; n = n.Next);
            n.Next = newNode;
        }   
            
        public void Add(int newData, int index)
        {   
            if(index < 0 || index>Count - 1)
            {
                return;
            }
            Node newNode = new Node(newData);
            Node n;
            int count = 0;
            for (n=head; count != index-1; n = n.Next, count++);
            newNode.Next = n.Next;
            n.Next = newNode;
            
        }   
            
        public Node this[int index]
        {   
            get {
                if(index<0 || index>Count - 1)
                    return null;
                int c = 0;
                Node n;
                for (n = head; c != index; c++, n = n.Next) ;
                return n;
            }
            set
            {
                Add(value.Data, index);
            }
        }   
            
        public void RemoveFirst()
        {   
            head = head.Next;
        }   
            
        public void RemoveLast()
        {   
            Node n;
            for(n=head; n.Next.Next != null; n = n.Next) ;
            n.Next = null;
        }   
            
        public int? Search(int value)
        {
            int index = 0;
            for (Node n = head; n != null; n = n.Next, index++)
                if (n.Data == value)
                    return index;
            return null;
        }   
            
        public void WriteLine()
        {   
            Console.WriteLine();
            for(Node n=head; n != null; n = n.Next)
            {
                Console.Write(n.Data + " -> ");
            }
            Console.WriteLine("null");
        }
    }
}
