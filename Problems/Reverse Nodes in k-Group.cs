using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {

            ListNode[] buffer = new ListNode[k];

            ListNode curr = head;
            ListNode prev = null;

            int i = buffer.Length;

            while (curr != null)
            {

                if (i > 0)
                {
                    buffer[--i] = curr;
                }

                if (i == 0)
                {
                    ListNode next = curr.next;

                    if (prev == null)
                    {
                        head = buffer[0];
                    }
                    else
                    {
                        prev.next = buffer[0];
                    }

                    int j;

                    for (j = 0; j < buffer.Length - 1; j++)
                    {
                        buffer[j].next = buffer[j + 1];
                        buffer[j] = null;
                    }

                    prev = buffer[j];

                    buffer[j].next = next;
                    buffer[j] = null;

                    i = buffer.Length;

                    curr = next;
                    continue;
                }

                curr = curr.next;
            }

            return head;
        }
    }
}
