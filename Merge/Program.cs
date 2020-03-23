using System;

namespace Merge
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node next;
        };


        static Node newNode(int key)
        {
            Node temp = new Node();
            temp.data = key;
            temp.next = null;
            return temp;
        }


        static void printList(Node node)
        {
            while (node != null)
            {
                Console.Write("{0} ", node.data);
                node = node.next;
            }
        }


        static Node Merge(Node h1, Node h2)
        {
            if (h1 == null)
                return h2;
            if (h2 == null)
                return h1;


            if (h1.data < h2.data)
            {
                h1.next = Merge(h1.next, h2);
                return h1;
            }
            else
            {
                h2.next = Merge(h1, h2.next);
                return h2;
            }
        }


        public static void Main(String[] args)
        {
            Node head1 = newNode(1);
            head1.next = newNode(2);
            head1.next.next = newNode(4);


            Node head2 = newNode(1);
            head2.next = newNode(3);
            head2.next.next = newNode(7);



            Node Mergedhead = Merge(head1, head2);

            printList(Mergedhead);
        }
    }

}

