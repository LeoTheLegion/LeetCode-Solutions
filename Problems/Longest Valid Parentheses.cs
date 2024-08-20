using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int LongestValidParentheses(string s)
        {

            int longest = 0;

            Stack<int> p = new Stack<int>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (c == '(')
                {
                    p.Push(i);
                    continue;
                }

                if (p.Count == 0)
                {
                    if(i < s.Length - 1)
                    {
                        return Math.Max(longest, LongestValidParentheses(s.Substring(i + 1, s.Length - i - 1)));
                    }
                }
                else
                {
                    p.Pop();
                    longest += 2;
                }
            }

            if (p.Count > 0)
            {
                int lastFailed = p.Pop();

                while (p.Count > 0)
                {
                    lastFailed = p.Pop();
                }

                longest = lastFailed;
                if (lastFailed < s.Length)
                {
                    return Math.Max(longest, LongestValidParentheses(s.Substring(lastFailed + 1, s.Length - lastFailed - 1)));
                }
            }

            return longest;
        }
    }
}
