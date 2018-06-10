using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class MyQueue
    {
        public int inf;
        public MyQueue next;
        public MyQueue (int inf, MyQueue next)            
        {
            this.inf = inf;
            this.next = next;
        }

        Node head;                            
        Node tail;
        public int count;                       

        public MyQueue()
        {
            head = null; tail = null; count = 0;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool QueueIsEmpty()             
        {
            return head == null;
        }

        public void InQueue(int inf)            
        {
            Node p = new Node(inf, null);
            if (QueueIsEmpty())
            {
                head = p; tail = p;
            }
            else
            {
                tail.next = p; tail = p;
            }
            count++;
        }

        public int Out()
        {
            Node p = head;
            head = head.next;
            count--;
            return p.inf;
        }

        public string[] Printer()
        {
            int L = 0;
            string[] st = new string[0];
            Node p = head;
            while (p != null)
            {
                Array.Resize<string>(ref st, ++L);
                st[L - 1] = p.inf.ToString();
                p = p.next;
            }
            return st;
        }

        public static MyQueue Task(MyQueue mq)
        {

            int x = mq.Out();
            MyQueue queue = new MyQueue();
            queue.InQueue(x);
            while (mq.head != null)
            {
                var tmp = mq.Out();
                if (tmp != x)
                {
                    x = tmp;
                    queue.InQueue(x);
                }
            }
            return queue;
        }
    }
}
