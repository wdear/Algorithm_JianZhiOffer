using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }


        class PrintListFromTailToHead
    {

        /// <summary>
        /// Stack
        /// </summary>
        public List<int> PrintListFromTailToHeadStack(ListNode listNode)
        {
            // write code here
            Stack<int> st = new Stack<int>();
            while (listNode != null)
            {
                st.Push(listNode.val);
                listNode = listNode.next;
            }
            List<int> tTh = new List<int>();
            while (st.Count != 0)
            {
                tTh.Add(st.Pop());
            }

            return tTh;
        }

        /// <summary>
        /// 递归，超时???
        /// </summary>
        public List<int> PrintListFromTailToHeadRecursive(ListNode listNode)
        {
            // write code here
            List<int> tTh = new List<int>();
            while (listNode != null)
            {
                tTh = PrintListFromTailToHeadRecursive(listNode.next);
                tTh.Add(listNode.val);
            }

            return tTh;
        }

        /// <summary>
        /// 逆序链表
        /// </summary>
        public List<int> PrintListFromTailToHeadReverse(ListNode listNode)
        {
            ListNode h = new ListNode(0);
            while (listNode != null)
            {
                ListNode t = listNode.next;
                listNode.next = h.next;
                h.next = listNode;
                listNode = t;
            }
            h = h.next;

            List<int> tTh = new List<int>();
            while (h != null)
            {
                tTh.Add(h.val);
                h = h.next;
            }
            return tTh;
        }
    }
}
