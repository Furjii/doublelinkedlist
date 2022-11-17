using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doublelinkedlist
{
    class Node
    {
        /*Node class represents the node of doubly linked list.
         * Its consists of the information part and links to
         * its succedding and preceeding nodes
         * in terms of next and previous node. */
        public int rollNumber;
        public string name;
        public Node next;/*points to the succeeding node*/
        public Node prev;/*points to the preceeding node*/
    }

    class DoubleLinkedList
    {
        Node START;
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
