using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ArrayUtils
    {
        public int Value { get; private set; }
        public ArrayUtils(int value)
        {
            this.Value = value;
        }
        Random rnd = new Random();

        public int[] ArrayCreater()
        {
            int[] arr = new int[Value];
            for (int i = 0; i < Value; i++)
            {
                arr[i] = rnd.Next(1, 99);
            }
            return arr;
        }

    }
}
