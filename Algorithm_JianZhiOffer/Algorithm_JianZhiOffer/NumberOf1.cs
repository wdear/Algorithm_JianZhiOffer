using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 原码、反码、补码
/// 正整数的原码、反码、补码完全一样，即符号位固定为0，数值位相同
/// 负数反码：原码符号位1不变，整数的每一位二进制数位求反，得到反码
/// 负数补码：反码符号位1不变，反码数值位最低位加1，得到补码
/// </summary>
namespace Algorithm_JianZhiOffer
{
    class NumberOf1
    {
        /// <summary>
        /// 一次通过一次不通过？？？
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumberOf1MyCode(int n)
        {
            if (n == 0)
                return 0;
            int tn;
            if (n > 0)
                tn = n;
            else
                tn = 2147483647 + n + 1;
            List<int> nList = new List<int>();
            while (tn > 0)
            {
                nList.Add(tn % 2);
                tn = tn / 2;
            }
            int count = 0;
            for (int i = 0; i < nList.Count; i++)
            {
                if (nList[i] == 1)
                    count++;
            }
            return n > 0 ? count : count + 1;

        }

        /// <summary>
        /// 位运算
        /// 按位与 &      同时为1才为1 （负数按补码形式参与&运算） 
        ///               用途：（1）清零，将清零的数与一个各位为0的相& 
        ///                     （2）取一个数中指定位 设X=10101110，取X的低4位，用 X & 0000 1111 = 00001110 即可得到
        /// 按位或 |      任意为1则为1 （负数按补码形式参与|运算）
        ///               用途：（1）对一个数据的某些位置1，将X=10100000的低4位置1 ，用X | 0000 1111 = 1010 1111即可得到。
        /// 按位异或 ^    不同为1同为0
        ///               用途：（1）X=10101110，使X低4位翻转，用X ^0000 1111 = 1010 0001即可得到。
        ///                     （2）与0相异或，保留原值 ，X ^ 00000000 = 1010 1110。
        ///               性质：交换律 结合律  x^x=0，x^0=x 自反性:  a^b^b=a^0=a（交换两个变量a,b：a=a^b; b=b^a; a=a^b;）
        /// 按位取反 ~    每一位取反
        /// 按位左移 <<   向左移动指定位数，空位填0
        /// 按位右移 >>   向右移动指定位数，正数左补0，负数左补1
        /// 不同长度位运算，右对齐，左补0（正数或无符号）或1（负数）
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumberOf1Bit(int n)
        {
            int count = 0;
            while (n != 0)
            {
                n = n & (n - 1);
                count++;
            }

            return count;

        }
     }
}

