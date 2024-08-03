using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public bool IsPalindrome(int x)
        {
            string s = x.ToString();

            for (int i = 0; i < s.Length / 2; i++)
            {
                int opps = s.Length - 1 - i;
                if (s[i] != s[opps])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
