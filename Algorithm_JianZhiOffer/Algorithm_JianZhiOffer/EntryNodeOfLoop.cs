using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class EntryNodeOfLoop
    {
        public ListNode EntryNodeOfLoop1(ListNode pHead)
        {
            // write code here
            ListNode slow = pHead;
            ListNode fast = pHead;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                {
                    fast = pHead;
                    while (fast != slow)
                    {
                        fast = fast.next;
                        slow = slow.next;
                    }
                    return fast;
                }
            }
            return null;
        }
    }
}
