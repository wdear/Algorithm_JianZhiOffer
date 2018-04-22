using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = {4,1,2,3,4,4,4,4,4,4 };
            MinNumberInRotateArray a = new MinNumberInRotateArray();
            Console.WriteLine(a.MinNumberInRotateArray2(b));
        }
    }
}
