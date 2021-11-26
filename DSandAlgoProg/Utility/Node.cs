using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgoProg.Utility
{
    class Node<T>
    {
        public T data;
        public int idata;
        public Node<T> next;
        public Node(T data)
        {
            this.data = data;
            next = null;
        }
    }
}
