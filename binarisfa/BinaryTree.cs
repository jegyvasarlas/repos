using System;

namespace binarisfa
{
    class BinaryTree
    {
        Node root;
        int count;
        public int Count
        {
            get { return count; }
        }

        public BinaryTree()
        {
            root = null;
            count = 0;
        }
        public BinaryTree(int newData)
        {
            root = new Node(newData);
            count = 1;
        }

        public BinaryTree(BinaryTree other)
        {
            root = new Node(other.root);
        }

        public void Add(int newData)
        {
            if (IsEmpty())
            {
                root = new Node(newData);
                count++;
                return;
            }
            Node n = root;
            bool inserted = false;
            while (!inserted)
            {
                if(newData <= n.Data)
                {
                    if(n.Left == null)
                    {
                        n.Left = new Node(newData);
                        inserted = true;
                        count++;
                    }
                    n = n.Left;
                }
                else
                {
                    if(n.Right == null)
                    {
                        n.Right = new Node(newData);
                        inserted = true;
                        count++;
                    }
                    n = n.Right;
                }
            }
        }
        public void InOrder()
        {
            InOrder(root);
            Console.WriteLine();
        }
        private void InOrder(Node n)
        {
            if (n.Left != null)
            {
                InOrder(n.Left);
            }
            Console.Write(n.Data + " ");
            if (n.Right != null)
                InOrder(n.Right);
        }

        public int Depth()
        {
            return Depth(root);
        }
        private int Depth(Node n)
        {
            if(n == null)
                return 0;
            if(Depth(n.Left) >= Depth(n.Right))
                return Depth(n.Left) + 1;
            else
                return Depth(n.Right) + 1;
        }

        public int MaxValue()
        {
            Node n = root;
            while (n.Right == null)
                n = n.Right;

            return n.Data;
        }

        public int MinValue()
        {
            Node n = root;
            while (n.Left == null)
                n = n.Left;

            return n.Data;
        }

        public bool IsElement(int value)
        {
            Node n = root;
            while(n!=null && n.Data != value)
            {
                if (value < n.Data)
                    n = n.Left;
                else if (value > n.Data)
                    n = n.Right;
            }
            return n == null ? false : true;
        }

        public bool IsEmpty()
        {
            return root == null;
        }
    }
}
