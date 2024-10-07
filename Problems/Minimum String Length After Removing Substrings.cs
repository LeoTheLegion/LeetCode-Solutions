using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int MinLength(string s)
        {
            while (s.IndexOf("AB") + s.IndexOf("CD") >= -1)
            {
                s = s.Replace("AB", "").Replace("CD", "");
            }

            return s.Length;
        }
    }
}
