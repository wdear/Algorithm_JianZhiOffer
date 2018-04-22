using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class MinNumberInRotateArray
    {
        /// <summary>
        /// 二分查找  复杂度：O(logN) + O(1)    {4,1,2,3,4,4,4,4,4,4}错误？？？？（剑指offer：三个指针相等时顺序查找？？）
        /// </summary>
        /// <param name="rotateArray"></param>
        /// <returns></returns>
        public int MinNumberInRotateArray1(int[] rotateArray)
        {
            // write code here
            int len = rotateArray.Length;
            if (len == 0)
                return 0; 
            int i = 0;
            int j = len - 1;
            while (rotateArray[i] >= rotateArray[j])
            {
                if (j - i == 1)
                    return rotateArray[j];
                int m = i + (j - i) / 2;
                if (rotateArray[i] <= rotateArray[m])
                    i = m;
                else
                    j = m;
            }

            return rotateArray[i];

        }


        /// <summary>
        /// 分治  递归      复杂度：O(logN) + O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinNumberInRotateArray2(int[] rotateArray)
        {
            // write code here
            int len = rotateArray.Length;
            if (len == 0)
                return 0;
            return minNumber(rotateArray, 0, len - 1);
        }

        private int minNumber(int[] array, int start, int end)
        {
            if (array[start] < array[end])
                return array[start];
            if (start == end)
                return array[start];
            int mid = start + (end - start) / 2;
            return Math.Min(minNumber(array, start, mid), minNumber(array, mid + 1, end));
        }
    }
}
