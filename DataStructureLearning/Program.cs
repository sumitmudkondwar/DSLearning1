using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLearning
{
    class Node
    {
        public int value { get; set; }
        public Node Next { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node { value = 3 };

            Node middle = new Node { value = 5 };

            first.Next = middle;

            Node last = new Node { value = 7 };

            middle.Next = last;

            PrintList(first);
        }

        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.Next;
            }
        }
    }
}
