using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class Merge2Lists
    {
        /// <summary>
        /// 迭代
        /// </summary>
        /// <param name="pHead1"></param>
        /// <param name="pHead2"></param>
        /// <returns></returns>
        public ListNode MergeIter(ListNode pHead1, ListNode pHead2)
        {
            // write code here
            ListNode newHead = new ListNode(0);
            ListNode p = newHead;
            ListNode p1 = pHead1;
            ListNode p2 = pHead2;
            while (p1 != null && p2 != null)
            {
                if (p1.val < p2.val)
                {
                    newHead.next = p1;
                    p1 = p1.next;
                }
                else
                {
                    newHead.next = p2;
                    p2 = p2.next;
                }
                newHead = newHead.next;
            }
            if (p1 != null)
            {
                newHead.next = p1;
            }
            if (p2 != null)
            {
                newHead.next = p2;
            }
            return p.next;
        }

        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="pHead1"></param>
        /// <param name="pHead2"></param>
        /// <returns></returns>
        public ListNode MergeRec(ListNode pHead1, ListNode pHead2)
        {
            // write code here
            if (pHead1 == null) return pHead2;
            if (pHead2 == null) return pHead1;
            if (pHead1.val < pHead2.val)
            {
                pHead1.next = MergeRec(pHead1.next, pHead2);
                return pHead1;
            }
            else
            {
                pHead2.next = MergeRec(pHead1, pHead2.next);
                return pHead2;
            }

        }
    }
}
