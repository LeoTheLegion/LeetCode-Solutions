using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int MinAddToMakeValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            int fail = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (c == '(')
                    stack.Push(c);
                else if (stack.Count > 0)
                {
                    stack.Pop();
                }
                else
                {
                    fail++;
                }

            }

            return fail + stack.Count;
        }
    }
}
