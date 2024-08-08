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
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

            if (list1 == null) return list2;
            if (list2 == null) return list1;

            if (list1.val > list2.val) return MergeTwoLists(list2, list1);

            ListNode start = list1;
            ListNode tail = start;

            while (start != null)
            {

                if (list2 == null) return list1;

                int min = start.val;
                int max = (start.next != null) ? start.next.val : 100;

                if (min <= list2.val && list2.val <= max)
                {
                    ListNode insert = list2;

                    list2 = list2.next;

                    ListNode end = start.next;
                    start.next = insert;
                    insert.next = end;

                    tail = insert;
                    start = insert;
                    continue;
                }
                tail = start;
                start = start.next;
            }

            tail.next = list2;

            return list1;
        }
    }
}
