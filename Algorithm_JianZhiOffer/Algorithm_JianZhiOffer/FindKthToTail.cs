using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class FindKthToTail
    {
        public ListNode FindKthToTailMyCode(ListNode head, int k)
        {
            if (k < 1 || head == null)
                return null;
            ListNode key = head;
            ListNode p = head;
            int n = k;
            while (n > 0 && p != null)
            {
                p = p.next;
                n--;
            }
            if (n > 0)              //n超过链表长度的情况
                return null;
            while (p != null)
            {
                p = p.next;
                key = key.next;
            }
            return key;
        }


    }
}
