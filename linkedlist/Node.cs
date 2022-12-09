using System;

namespace linkedlist
{
    class Node
    {
        int data;
        Node next;
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
}
