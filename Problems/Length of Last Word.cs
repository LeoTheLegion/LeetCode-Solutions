using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int LengthOfLastWord(string s)
        {

            int i = s.Length;

            while (i > 0)
            {
                if (s[i - 1] == ' ')
                {
                    i--;
                    continue;
                }
                break;
            }

            int j = i;

            while (j > 0)
            {
                if (s[j - 1] != ' ')
                {
                    j--;
                    continue;
                }
                break;
            }

            return i - j;
        }
    }
}
