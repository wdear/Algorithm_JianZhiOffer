using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class _2StacksRepQueue
    {
        Stack<int> sl = new Stack<int>();
        Stack<int> sr = new Stack<int>();
        public void push(int node)
        {
            while (sr.Count > 0)
            {
                sl.Push(sr.Pop());
            }
            sl.Push(node);
        }
        public int pop()
        {
            while (sl.Count > 0)
            {
                sr.Push(sl.Pop());
            }
            if (sr.Count == 0)
                throw new Exception("queue is empty!");
            return sr.Pop();
        }
    }
}
