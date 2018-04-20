using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class ReverseLis
    {
        /// <summary>
        /// 迭代
        /// </summary>
        /// <param name="pHead"></param>
        /// <returns></returns>
        public ListNode ReverseListIter(ListNode pHead)
        {
            // write code here
            if (pHead == null)
                return null;

            ListNode revHead = null;
            ListNode curNode = pHead;
            ListNode preNode = null;

            while (curNode != null)
            {
                ListNode nextNode = curNode.next;
                if (nextNode == null)
                {
                    revHead = curNode;
                }
                curNode.next = preNode;
                preNode = curNode;
                curNode = nextNode;
            }

            return revHead;
        }

        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="pHead"></param>
        /// <returns></returns>
        public ListNode ReverseListRec(ListNode pHead)
        {
            if (pHead == null || pHead.next == null)
                return pHead;
            ListNode next = pHead.next;
            pHead.next = null;
            ListNode newHead = ReverseListRec(next);
            next.next = pHead;
            return newHead;

        }
    }
}
