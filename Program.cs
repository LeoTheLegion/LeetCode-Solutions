// See https://aka.ms/new-console-template for more information
using LeetCode;
using LeetCode.Problems;

Solution s = new Solution();


ListNode[] listNodes = new ListNode[3];

ListNode l1 = Helper.CreateList(new int[] { 1, 2, 3, 4, 5 });

//Helper.PrintList(s.ReverseKGroup(l1,2));

//Helper.PrintListOfLists(s.FourSum(new int[] { 1000000000, 1000000000, 1000000000, 1000000000 }, -294967296));

//Helper.PrintList(s.LetterCombinations('23'));

string board = "[[ 5 ,  3 ,  . ,  . ,  7 ,  . ,  . ,  . ,  . ], [ 6 ,  . ,  . ,  1 ,  9 ,  5 ,  . ,  . ,  . ], [ . ,  9 ,  8 ,  . ,  . ,  . ,  . ,  6 ,  . ], [ 8 ,  . ,  . ,  . ,  6 ,  . ,  . ,  . ,  3 ], [ 4 ,  . ,  . ,  8 ,  . ,  3 ,  . ,  . ,  1 ], [ 7 ,  . ,  . ,  . ,  2 ,  . ,  . ,  . ,  6 ], [ . ,  6 ,  . ,  . ,  . ,  . ,  2 ,  8 ,  . ], [ . ,  . ,  . ,  4 ,  1 ,  9 ,  . ,  . ,  5 ], [ . ,  . ,  . ,  . ,  8 ,  . ,  . ,  7 ,  9 ]]";

char[][] b = Helper.ConvertStringInto2DArray<char>(board);

//Helper.Print2DArray(b);

//Console.WriteLine(s.IsValidSudoku(b));

//Console.WriteLine(s.SearchInsert(new int[] { 1, 3, 5, 6 },2));

Console.WriteLine(s.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
