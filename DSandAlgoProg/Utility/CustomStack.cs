using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgoProg.Utility
{
    class CustomStack<T>
    {
        public Node<T> top;
        public void Push(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} Pushed into Stack", data);
        }
        public void Pop(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
                top = top.next;
            }

            Console.WriteLine("{0} Pop into Stack", top.data);
        }
        internal bool Isempty()
        {
            Node<T> node = this.top;
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            return false;
        }
    }
}
