using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {

            ListNode curr = head;

            if (curr != null && curr.next != null)
            {// protect for first swap
                head = head.next;
            }

            ListNode prev = null;

            while (curr != null && curr.next != null)
            {

                ListNode a = curr;
                ListNode b = curr.next;
                ListNode c = curr.next.next;

                b.next = a;

                a.next = c;

                if (prev != null)
                {
                    prev.next = b;
                }

                curr = c;
                prev = a;
            }

            return head;

        }
    }
}
