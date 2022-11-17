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
        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNode()/*Adds anew node*/
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            /*Checks if the list is empty*/
            if (START == null || rollNo <= START.rollNumber)
            {
                if ((START != null) && (rollNo == START.rollNumber))
                {
                    Console.WriteLine("\nDuplicate roll number not allowed");
                    return;
                }
                newnode.next = START;
                if (START != null)
                    START.prev = newnode;
                newnode.prev = null;
                START = newnode;
                return;

            }
            Node previous, current;
            for (current = previous = START; current != null &&
                rollNo >= current.rollNumber; previous = current, current = current.next)
            {
                if (rollNo == current.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll number not allowed");
                    return;
                }
            }
            /*On the execution of the above for loop, prev and
             * current will point to those nodes
             between which the new node is to be inserted.*/
            newnode.next = current;
            newnode.prev = previous;

            /*if the nodes is to be inserted at the end of the list.*/
            if (current == null)
            {
                newnode.next = null;
                previous.next = newnode;
                return;
            }
            current.prev = newnode;
            previous.next = newnode;
        }

        /*Cheks whether the specified node is present*/
        public bool Seacth(int rollNo, ref Node previous, ref Node current)
        {
            for (previous = current = START; current != null &&
                rollNo != current.rollNumber; previous = current,current = current.next)
            { }
            /*the above for loop traverse the list. if the specified node
             * is found then the function return true, otherwise false.*/
            return (current != null);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
