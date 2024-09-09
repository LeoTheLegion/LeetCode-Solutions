using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (head == null || head.next == null || left == right)
            {
                return head;
            }

            ListNode[] nodesToReverse = new ListNode[right - left + 1];
            int i = 0;


            ListNode curr = head;
            ListNode rotateLeft = null;
            ListNode rotateRight = null;

            // Find the nodes to reverse
            while (curr != null)
            {
                // If we are at the node before the range of nodes to reverse
                if (i == left - 2)
                {
                    rotateLeft = curr;
                }
                // If we are in the range of nodes to reverse
                else if (i >= left - 1 && i <= right - 1)
                {
                    nodesToReverse[i - left + 1] = curr;
                }
                // If we are at the node after the range of nodes to reverse
                else if( i == right)
                {
                    rotateRight = curr;
                    break;
                }

                i++;
                curr = curr.next;
            }

            // Link nodes in reverse
            for (int j = nodesToReverse.Length - 1; j > 0; j--)
            {
                nodesToReverse[j].next = nodesToReverse[j - 1];
            }

            // Set Left Side
            if(rotateLeft != null)
                rotateLeft.next = nodesToReverse[nodesToReverse.Length - 1];
            else
                head = nodesToReverse[nodesToReverse.Length - 1];

            // Set Right Side
            nodesToReverse[0].next = rotateRight;

            return head;
        }
    }
}
