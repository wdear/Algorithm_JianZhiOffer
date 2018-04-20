using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class IsPopOrder
    {
        public bool IsPopOrderM(int[] pushV, int[] popV)
        {
            // write code here
            int len = pushV.Length;
            Stack<int> st = new Stack<int>();
            int j = 0;
            for (int i = 0; i < len; i++)
            {
                st.Push(pushV[i]);
                while (j < len && popV[j] == st.Peek())
                {
                    st.Pop();
                    j++;
                }
            }
            if (st.Count > 0)
                return false;
            else
                return true;
        }
    }
}
