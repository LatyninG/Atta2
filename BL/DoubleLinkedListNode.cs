using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DoubleLinkedListNode<T>
    {
        public T Value;
        public DoubleLinkedListNode<T> Next;
        public DoubleLinkedListNode<T> Prev;

        public DoubleLinkedListNode(T value, DoubleLinkedListNode<T> prev = null, DoubleLinkedListNode<T> next = null)
        {
            Value = value;
            Prev = prev;
            Next = next;
        }
    }
}
