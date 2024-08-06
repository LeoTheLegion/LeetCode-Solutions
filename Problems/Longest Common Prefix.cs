using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {

            string out_string ="";

            int min = Int32.MaxValue;

            for (int i = 0; i < strs.Length; i++)
            {
                min = Math.Min(min, strs[i].Length);
            }

            for (int i = 0; i < min; i++)
            {
                char c1 = strs[0][i];

                for (int j = 1; j < strs.Length; j++)
                {
                    char c2 = strs[j][i];
                    if (c2 != c1)
                    {
                        return out_string;
                    }
                }

                out_string += c1;
            }

            return out_string;
        }
    }
}
