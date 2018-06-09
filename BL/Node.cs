using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Node
    {
        public int inf;
        public Node next;
        public Node(int inf, Node next)            
        {
            this.inf = inf;
            this.next = next;
        }
    }
}
