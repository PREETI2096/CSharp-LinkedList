using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class MyLinkedList<T>
    {
       
        public Node<T> head;
        public Node<T> tail;

        public MyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void addFirst(Node<T> node)
        {
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                Node<T> tempNode = head;
                head = node;
                head.Next = tempNode;
            }
        }

        public void displayLikedList()
        {
            StringBuilder myLinkedList = new StringBuilder();
            Node<T> tempNode = head;
            while (tempNode.Next != null)
            {
                myLinkedList.Append(tempNode.Key);
                if (!tempNode.Equals(tail))
                    myLinkedList.Append("->");
                tempNode = tempNode.Next;
            }
            myLinkedList.Append(tempNode.Key);
            Console.WriteLine(myLinkedList);
        }
    }
}
