// See https://aka.ms/new-console-template for more information
using LeetCode;
using LeetCode.Problems;

Solution s = new Solution();


ListNode[] listNodes = new ListNode[3];

ListNode l1 = Helper.CreateList(new int[] { 3, 5 });

//Helper.PrintList(s.ReverseBetween(l1,1,2));


MyCircularDeque obj = new MyCircularDeque(4);
bool param_1 = obj.InsertFront(4);
bool param_3 = obj.InsertFront(5);
bool param_2 = obj.DeleteLast();


