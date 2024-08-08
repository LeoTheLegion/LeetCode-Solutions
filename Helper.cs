using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Problems;

namespace LeetCode
{
    public class Helper
    {
        public static ListNode CreateList(int[] values)
        {
            ListNode head = new ListNode(values[0]);
            ListNode current = head;

            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }

            return head;
        }

        public static void PrintList(ListNode list)
        {
            while (list != null)
            {
                Console.Write(list.val + " ");
                list = list.next;
            }
        }
    }
}
