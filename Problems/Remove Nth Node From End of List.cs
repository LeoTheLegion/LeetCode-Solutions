using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
    public partial class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {

            int i = 0;
            ListNode curr = head;

            Dictionary<int, ListNode> dictionary = new Dictionary<int, ListNode>();

            while (curr != null)
            {
                dictionary.Add(i, curr);

                i++;
                curr = curr.next;
            }

            ListNode l1 = (dictionary.ContainsKey(dictionary.Count - n - 1)) ? dictionary[dictionary.Count - n - 1] : null;
            ListNode l2 = (dictionary.ContainsKey(dictionary.Count - n + 1)) ? dictionary[dictionary.Count - n + 1] : null;

            if (l1 != null)
            {
                l1.next = l2;
            }
            else
            {
                head = l2;
            }

            return head;
        }
    }
}
