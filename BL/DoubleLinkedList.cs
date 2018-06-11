using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DoubleLinkedList<T>
    {
        private DoubleLinkedListNode<T> _head;
        private DoubleLinkedListNode<T> _tail;

        private int _count;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public bool Empty
        {
            get
            {
                return _count == 0;
            }
        }

        public DoubleLinkedListNode<T> First
        {
            get
            {
                return _head;
            }
        }

        public DoubleLinkedList()
        {

        }

        public void Add(T value)
        {
            if (Empty)
                _head = _tail = new DoubleLinkedListNode<T>(value, null, null);

            else
            {
                _tail = new DoubleLinkedListNode<T>(value, _tail, null);
                _tail.Prev.Next = _tail;
            }

            _count++;
        }
    }
}
