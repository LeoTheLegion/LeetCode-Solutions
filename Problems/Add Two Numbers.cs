using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public partial class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            ListNode n1 = l1;
            ListNode n2 = l2;
            ListNode startingChain = null;
            ListNode tempChain = null;
            bool carry = false;

            while (n1 != null)
            {

                ListNode newNode = new ListNode();
                if (n2 == null)
                    newNode.val = n1.val;
                else
                {
                    newNode.val = n1.val + n2.val;

                    n2 = n2.next;
                }
                n1 = n1.next;

                if (carry)
                {
                    newNode.val += 1;
                }

                if (newNode.val >= 10)
                {
                    newNode.val -= 10;
                    carry = true;
                }
                else
                {
                    carry = false;
                }

                if (startingChain == null)
                {
                    startingChain = tempChain = newNode;
                }
                else
                {
                    tempChain.next = newNode;
                    tempChain = tempChain.next;
                }
            }

            while (n2 != null)
            {
                ListNode newNode = new ListNode();
                newNode.val = n2.val;
                n2 = n2.next;

                if (carry)
                {
                    newNode.val += 1;
                }

                if (newNode.val >= 10)
                {
                    newNode.val -= 10;
                    carry = true;
                }
                else
                {
                    carry = false;
                }

                if (startingChain == null)
                {
                    startingChain = tempChain = newNode;
                }
                else
                {
                    tempChain.next = newNode;
                    tempChain = tempChain.next;
                }
            }

            if (carry)
            {
                tempChain.next = new ListNode(1);
            }

            return startingChain;

        }
    }
}
