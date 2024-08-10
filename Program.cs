// See https://aka.ms/new-console-template for more information
using LeetCode;
using LeetCode.Problems;

Solution s = new Solution();


ListNode l1 = Helper.CreateList(new int[] { 1, 2, 4 });
ListNode l2 = Helper.CreateList(new int[] { 1, 3, 4 });

//Helper.PrintList(s.MergeTwoLists(l1, l2));

//Helper.PrintListOfLists(s.ThreeSum(new int[] { 1, -1, -1, 0 }));

Console.WriteLine(s.ThreeSumClosest(new int[] { -1, 2, 1, -4 },1));
