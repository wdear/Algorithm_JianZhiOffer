using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class Fibonacci
    {
        /// <summary>
        /// 动态规划 空间复杂度O(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FibonacciDP(int n)
        {
            // write code here
            if (n < 2)
                return n;
            int[] s = new int[n + 1];
            s[0] = 0;
            s[1] = 1;
            for (int i = 2; i < n + 1; i++)
            {
                s[i] = s[i - 1] + s[i - 2];
            }
            return s[n];
        }

        /// <summary>
        /// 只存储前两项 空间复杂度O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fibonacci2(int n)
        {
            // write code here
            if (n < 2)
                return n;
            int p2 = 0;
            int p1 = 1;
            int rlt = 0;
            for (int i = 2; i < n + 1; i++)
            {
                rlt = p1 + p2;
                p2 = p1;
                p1 = rlt;
            }
            return rlt;
        }
    }
}
