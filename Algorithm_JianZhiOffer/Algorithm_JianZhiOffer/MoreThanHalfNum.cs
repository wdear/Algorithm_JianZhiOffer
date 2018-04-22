using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class MoreThanHalfNum
    {
        /// <summary>
        /// O(N)
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int MoreThanHalfNum_Solution(int[] numbers)
        {
            // write code here
            int len = numbers.Length;
            if (len < 1)
                return 0;
            if (len == 1)
                return numbers[0];
            int cnt = 1;
            int maj = numbers[0];
            for (int i = 1; i < len; i++)
            {
                if (numbers[i] == maj)
                    cnt++;
                else
                    cnt--;
                if (cnt == 0)
                {
                    maj = numbers[i];
                    cnt = 1;
                }
            }
            cnt = 0;
            foreach (int x in numbers)
            {
                if (x == maj)
                    cnt++;
            }

            return cnt > len / 2 ? maj : 0;
        }
    }
}
