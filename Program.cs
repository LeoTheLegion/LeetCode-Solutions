// See https://aka.ms/new-console-template for more information
using LeetCode;
using LeetCode.Problems;

Solution s = new Solution();


ListNode[] listNodes = new ListNode[3];

ListNode l1 = Helper.CreateList(new int[] { 3, 5 });

Helper.PrintList(s.ReverseBetween(l1,1,2));

