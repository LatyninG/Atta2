using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace BL
{
    public class SortBL
    {
        public int Count_obm;
        public int Count_srav;
        public int N { get; private set; }
        public int[] Arr { get; private set; }
        public SortBL(int n, int[] arr)
        {
            this.Arr = arr;
            this.N = n;
        }


        public void SortShell()
        {
            Count_obm = 0; Count_srav = 0;
            int d = N / 2;
            while (d > 0)
            {
                bool Ok = true;
                while(Ok)
                {
                    Ok = false;
                    for (int i = 0; i < N -d; i++)
                    {
                        if (Arr[i] > Arr[i + d])
                        {
                            int t = Arr[i]; Arr[i] = Arr[i + d]; Arr[i + d] = t;
                            Ok = true;
                            Count_obm ++;
                        }
                        Count_srav++;
                    }
                }
                d = d / 2;
            }
        }

        public void BubleSort()
        {
            Count_obm = 0; Count_srav = 0;
            for (int i = 0; i < Arr.Length - 1; i++)
                for (int j = Arr.Length - 1; j > i; j--)
                {
                    Count_srav++;
                    if (Arr[i] > Arr[j])
                    {
                        int t = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = t;
                    }
                    Count_obm++;
                }
        }

        public int ReturnSrav()
        {
            return Count_srav;
        }

        public int ReturnObm()
        {
            return Count_obm;
        }
    }
}
