using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class ReOrderArray
    {
        public int[] reOrderArray(int[] array)
        {
            // write code here
            if (array.Length < 2)
                return array;
            int k = array.Length - 1;
            while (array[k] % 2 == 0)
            {
                k--;
            }
            while (k >= 0)
            {
                if (array[k] % 2 == 0)
                {
                    int j = k + 1;
                    while (j < array.Length && array[j] % 2 != 0)
                    {
                        int t = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = t;
                        j++;
                    }
                }
                k--;
            }

            return array;
        }


        /// <summary>
        /// 不改变原数组 O(N) + O(N)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] reOrderArrayNew(int[] array)
        {
            int oddCnt = 0;
            foreach (int x in array)
            {
                if (x % 2 != 0)
                    oddCnt++;
            }
            int[] rslt = new int[array.Length];
            int i = 0;
            int j = oddCnt;
            foreach (int x in array)
            {
                if (x % 2 != 0)
                {
                    rslt[i] = x;
                    i++;
                }
                else
                {
                    rslt[j] = x;
                    j++;
                }
            }

            return rslt;
        }
    }
}
