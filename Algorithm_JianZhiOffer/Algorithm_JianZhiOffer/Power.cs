using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class Power
    {
        bool isInvalidInput = false;
        public double Power1(double thebase, int exponent)
        {
            // write code here
            isInvalidInput = false;
            if (equal(thebase, 0.0) && exponent < 0)
            {
                isInvalidInput = true;
                return 0.0;
            }
            uint absExponent = (uint)exponent;
            if (exponent < 0)
                absExponent = (uint)(-exponent);

            double result = PowerWithUintExponent(thebase, absExponent);
            if (exponent < 0)
                result = 1.0 / result;

            return result;

        }

        bool equal(double num1, double num2)
        {
            if ((num1 - num2 > -0.0000001) && (num1 - num2 < 0.0000001))
                return true;
            else
                return false;
        }

        double PowerWithUintExponent(double thebase, uint exponent)
        {
            if (exponent == 0)
                return 1;
            if (exponent == 1)
                return thebase;

            double result = PowerWithUintExponent(thebase, exponent >> 1);
            result = result * result;
            if ((exponent & 0x1 )== 1)
                result = result * thebase;

            return result;
        }
    }
}
