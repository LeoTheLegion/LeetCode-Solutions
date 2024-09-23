// See https://aka.ms/new-console-template for more information
using LeetCode;
using LeetCode.Problems;

Solution s = new Solution();


ListNode[] listNodes = new ListNode[3];

ListNode l1 = Helper.CreateList(new int[] { 3, 5 });

//Helper.PrintList(s.ReverseBetween(l1,1,2));

Console.WriteLine(s.MinExtraChar("eglglxa", new string[]
{
    "rs","j","h","g","fy","l","fc","s","zf","i","k","x","gl","qr","qj","b","m","cm","pe","y","ei","wg","e","c","ll","u","lb","kc","r","gs","p","ga","pq","o","wq","mp","ms","vp","kg","cu"
}));

