using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();

            while (head != null)
            {
                if (set.Contains(head))
                {
                    return true;
                }

                set.Add(head);
                head = head.next;
            }

            return false;
        }
    }
}
