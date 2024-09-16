using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            Dictionary<ListNode, int> dict = new Dictionary<ListNode, int>();

            ListNode current = head;

            while (current != null)
            {
                if (dict.ContainsKey(current))
                {
                    return current;
                }

                dict.Add(current, 1);
                current = current.next;
            }

            return null;
        }
    }
}
