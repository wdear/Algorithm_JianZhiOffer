using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class Power
    {
        /// <summary>
        /// 由于精度原因，double类型的变量不能用等号判断两个数是否相等，因此需要写equsl函数
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        bool doubleEqual(double num1, double num2)
        {
          if((num1 - num2)>-0.0000001 && (num1 - num2) < 0.0000001)
             return true;
          else
             return false;
        }

    /// <summary>
    /// 递归 O(logn)    输出的小数点不对？？？
    /// </summary>
    /// <param name="thebase"></param>
    /// <param name="exponent"></param>
    /// <returns></returns>
    public double PowerRec(double thebase, int exponent)
        {
            // write code here
            if (exponent == 0)
                return 1;
            if (exponent == 1)
                return thebase;
            bool isNegative = false;
            if (exponent < 0)
            {
                exponent = -exponent;
                isNegative = true;
            }
            double p = PowerRec(thebase * thebase, exponent / 2);
            if (exponent % 2 != 0)
                p = p * thebase;
            return isNegative ? (1 / p) : p;
        }


        /// <summary>
        /// 移位
        /// </summary>
        /// <param name="thebase"></param>
        /// <param name="exponent"></param>
        /// <returns></returns>
        public double PowerBit(double thebase, int exponent)
        {
            //如果底数为0且指数小于0，则表明是非法输入。
            if (doubleEqual(thebase, 0.0) && exponent < 0)
            {
                throw new Exception("input illegal!");
            }

            double result = 1;
            int n = Math.Abs(exponent);
            while (n != 0)
            {
                if ((n & 1) != 0)
                {
                    result *= thebase;
                }
                thebase *= thebase;
                n >>= 1;
            }
            return exponent < 0 ? 1.0 / result : result;
        }
    }
}
