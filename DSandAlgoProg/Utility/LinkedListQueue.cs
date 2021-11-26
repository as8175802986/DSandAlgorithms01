using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgoProg.Utility
{
    class LinkedListQueue<T>
    {
        Node<T> head = null;
        internal void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("{0} inserted into Queue", node.data);
            }
        }
        internal void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "\t");
                temp = temp.next;
            }
        }
        internal void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty,Deletion is not possible\n");
                return;
            }
            else
            {
                while (this.head != null)
                {
                    Console.WriteLine("\nValue Dequeued is {0}\n", this.head.data);
                    this.head = this.head.next;
                }
            }
        }
    }
}
