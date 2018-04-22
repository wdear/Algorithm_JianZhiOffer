﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    class FindFirstCommonNode
    {
        public ListNode FindFirstCommonNode1(ListNode pHead1, ListNode pHead2)
        {
            // write code here
            ListNode p1 = pHead1;
            ListNode p2 = pHead2;
            while (p1 != p2)
            {
                p1 = (p1 == null) ? pHead2 : p1.next;
                p2 = (p2 == null) ? pHead1 : p2.next;
            }

            return p1;
        }
    }
}
