using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HackathonWebQuestions
{
    public class QuestionTwo
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Add First:");
            LinkedList myList1 = new LinkedList();

            myList1.AddFirst("E");
            myList1.AddFirst("B");
            myList1.AddFirst("E");
            myList1.AddFirst("E");
            myList1.AddFirst("B");
            myList1.AddFirst("A");
            myList1.AddFirst("B");
           
            Console.WriteLine("Add Last:");
            LinkedList myList2 = new LinkedList();

            myList2.AddLast("E");
            myList2.AddLast("B");
            myList2.AddLast("E");
            myList2.AddLast("B");
            myList2.AddLast("A");
            
            Console.WriteLine("Delete node containg repeated data E");
            myList1.DeleteNode("E");
            Console.Read();

        }
    }

    public class Node
    {
        public Node next;
        public Object data;
    }
    public class LinkedList
    {
        private Node head;
        public void AddFirst(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }
        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }
        
        public void DeleteNode(object data)
        {
            if (head.data == data)
            {
                head = head.next;
            }
            else
            {
                Node removed = Find(data);
                if (removed.next != null)
                    removed.next = removed.next.next;
                else
                    Console.WriteLine("The given element is not found in the list");
            }
        }

        private Node Find(object data)
        {
            Node n = head;
            while (n.next != null)
            {
                if (n.next.data != data)
                {
                    n = n.next;
                }
                else
                    return n;
            }
            return n;
        }
    }
}
   