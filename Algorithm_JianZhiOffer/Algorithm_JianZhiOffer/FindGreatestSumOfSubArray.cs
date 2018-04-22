using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class FindGreatestSumOfSubArray
    {
        public int FindGreatestSumOfSubArrayMyCode(int[] array)
        {
            // write code here
            int len = array.Length;
            if (len < 1)
                return 0;
            if (len == 1)
                return array[0];
            int p = 0;
            int max = array[0];
            for (int i = 1; i < len; i++)
            {
                if (array[i] > 0)
                {
                    int temp1 = max;
                    int temp2 = array[i];
                    int k = p + 1;
                    while (k <= i)
                    {
                        temp1 = temp1 + array[k];
                        k++;
                    }
                    int temp = Math.Max(temp1, temp2);
                    max = max <= temp ? temp : max;
                    p = max <= temp ? i : p;
                }
                else
                {
                    if (max < 0)
                    {
                        max = max <= array[i] ? array[i] : max;
                        p = max <= array[i] ? i : p;
                    }
                }
            }
            return max;
        }

        /// <summary>
        /// 保留最大的和当前能累加的最大的
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int FindGreatestSumOfSubArrayBetter(int[] array)
        {
            int len = array.Length;
            if (len < 1)
                return 0;
            if (len == 1)
                return array[0];
            int sum = array[0];
            int max = sum;
            for (int i = 1; i < len; i++)
            {
                if (sum <= 0)
                    sum = array[i];
                else
                    sum = sum + array[i];
                max = Math.Max(sum, max);
            }
            return max;
        }
    }
}
