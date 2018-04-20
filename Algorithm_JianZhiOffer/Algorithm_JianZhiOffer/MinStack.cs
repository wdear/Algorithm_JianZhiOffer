using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class MinStack
    {
        /// <summary>
        /// ????
        /// </summary>
        Stack<int> st = new Stack<int>();
        Stack<int> minSt = new Stack<int>();
        int stMin = Int32.MaxValue;
        public void push(int node)
        {
            st.Push(node);
            if (node < stMin)
                stMin = node;
            minSt.Push(stMin);
        }
        public void pop()
        {
            if (st.Count > 0)
            {
                st.Pop();
            }
            if (minSt.Count > 0)
            {
                minSt.Pop();
                stMin = minSt.Peek();
            }

        }
        public int top()
        {
            if (st.Count > 0)
                return st.Peek();
            else
                return 0;
        }
        public int min()
        {
            if (minSt.Count > 0)
                return minSt.Peek();
            else
                return 0;
        }
    }
}
