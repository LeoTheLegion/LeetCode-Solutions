using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int Reverse(int x)
        {
            int sign = (x < 0) ? -1 : 1;

            string s = x.ToString();

            if (sign == -1)
            {
                s = s.Substring(1, s.Length - 1);
            }

            char[] chars = s.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = s[s.Length - 1 - i];
            }

            try
            {
                return int.Parse(new string(chars)) * sign;
            }
            catch (OverflowException ex)
            {
                return 0;
            }
        }
    }
}
