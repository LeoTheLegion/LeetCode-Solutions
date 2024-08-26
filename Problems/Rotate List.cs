using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {

            if (head == null || head.next == null)
            {
                return head;
            }

            Queue<int> q = new Queue<int>();

            ListNode current = head;

            while (current != null)
            {
                q.Enqueue(current.val);
                current = current.next;
            }

            int[] arr = q.ToArray();

            int[] rotated = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                rotated[(i + k) % arr.Length] = arr[i];
            }

            ListNode newHead = new ListNode(rotated[0]);

            ListNode newCurrent = newHead;

            for (int i = 1; i < rotated.Length; i++)
            {
                newCurrent.next = new ListNode(rotated[i]);
                newCurrent = newCurrent.next;
            }

            return newHead;

        }
    }
}
