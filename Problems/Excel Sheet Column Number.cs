using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int TitleToNumber(string columnTitle)
        {
            int sum = 0;

            for (int i = 0; i < columnTitle.Length; i++)
            {
                char c = columnTitle[i];

                int v = c - 'A' + 1;
                sum = sum * 26 + v;
            }

            return sum;
        }
    }
}
