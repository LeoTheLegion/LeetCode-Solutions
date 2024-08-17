// See https://aka.ms/new-console-template for more information
using LeetCode;
using LeetCode.Problems;

Solution s = new Solution();


ListNode[] listNodes = new ListNode[3];

ListNode l1 = Helper.CreateList(new int[] { 1, 4, 5 });

listNodes[0] = l1;

ListNode l2 = Helper.CreateList(new int[] { 1, 3, 4 });

listNodes[1] = l2;

ListNode l3 = Helper.CreateList(new int[] { 2, 6 });

listNodes[2] = l3;

Helper.PrintList(s.MergeKLists(listNodes));

//Helper.PrintListOfLists(s.FourSum(new int[] { 1000000000, 1000000000, 1000000000, 1000000000 }, -294967296));

//Helper.PrintList(s.LetterCombinations("23"));

//Console.WriteLine(s.StrStr("a", "a"));
