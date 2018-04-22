using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_JianZhiOffer
{
    public class RandomListNode
    {
        public int label;
        public RandomListNode next, random;
        public RandomListNode(int x)
        {
            this.label = x;
        }
    }

    class RandomListNodeClone
    {
        public RandomListNode Clone(RandomListNode pHead)
        {
            if (pHead == null)
            {
                return null;
            }
            // 插入新节点
            RandomListNode cur = pHead;
            while (cur != null)
            {
                RandomListNode clone = new RandomListNode(cur.label);
                clone.next = cur.next;
                cur.next = clone;
                cur = clone.next;
            }
            // 建立 random 链接
            cur = pHead;
            RandomListNode clone1 = new RandomListNode(0);
            while (cur != null)
            {
                clone1 = cur.next;
                if (cur.random != null)
                    clone1.random = cur.random.next;

                cur = clone1.next;
            }
            // 拆分
            cur = pHead;
            RandomListNode pCloneHead = pHead.next;
            while (cur.next != null)
            {
                RandomListNode next = cur.next;
                cur.next = next.next;
                cur = next;
            }
            return pCloneHead;

        }
    }
}
