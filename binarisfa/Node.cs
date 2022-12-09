using System;

namespace binarisfa
{
    class Node
    {
        int data;
        Node left;
        Node right;
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node Left
        {
            get { return left; }
            set { left = value; }
        }
        public Node Right
        {
            get { return right; }
            set { right = value; }
        }
        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }

        public Node(Node other)
        {
            this.data=other.data;

            if(other.left!=null)
                this.left = new Node(other.left);
            if (other.right != null)
                this.right = new Node(other.right);
        }
    }
}
