using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class DeleteDuplication
    {
        /// <summary>
        /// hmp写的代码嘻嘻
        /// </summary>
        /// <param name="pHead"></param>
        /// <returns></returns>
        public ListNode DeleteDuplicationInList(ListNode pHead)
        {
            // write code here
            ListNode head = new ListNode(0);
            head.next = pHead;
            //简化版初始化
            //ListNode head = new ListNode(0)
            //{
            //    next = pHead
            //};
            ListNode pNode = pHead;
            ListNode pre = head;
            while (pNode != null && pNode.next != null)
            {
                ListNode pNext = pNode.next;
                if (pNext.val == pNode.val)
                {
                    int val = pNode.val;
                    while (pNode != null && pNode.val == val)
                    {
                        pNode = pNode.next;
                    }
                    pre.next = pNode;
                }
                else
                {
                    pre = pNode;
                    pNode = pNext;
                }
            }
            return head.next;
        }

        /// <summary>
        /// Recursion
        /// </summary>
        /// <param name="pHead"></param>
        /// <returns></returns>
        public ListNode DeleteDuplicationRec(ListNode pHead)
        {
            // write code here
            if (pHead == null || pHead.next == null)
                return pHead;
            ListNode next = pHead.next;
            if (pHead.val == next.val)
            {
                while (next != null && pHead.val == next.val)
                {
                    next = next.next;
                }
                return DeleteDuplicationRec(next);
            }
            pHead.next = DeleteDuplicationRec(pHead.next);
            return pHead;
        }

    }
}
