using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {

            if (lists.Length == 1)
                return lists[0];

            ListNode head = lists[0];

            ListNode curr = head;

            ListNode add = lists[1];

            while (curr != null && add != null)
            {

                int x1 = curr.val;
                int x2 = (curr.next != null) ? curr.next.val : Int32.MaxValue;

                if (x1 <= add.val && add.val < x2)
                {
                    ListNode insert = add;

                    add = add.next;

                    ListNode temp = curr.next;

                    curr.next = insert;

                    insert.next = temp;

                }

                curr = curr.next;
            }

            ListNode[] newList = new ListNode[lists.Length - 1];
            newList[0] = head;

            for (int i = 1; i < newList.Length; i++)
            {
                newList[i] = lists[i + 1];
            }

            return MergeKLists(newList);
        }
    }
}
