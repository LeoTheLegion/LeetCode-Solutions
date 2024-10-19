using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public char FindKthBit(int n, int k)
        {
            // If n is 1, return 0
            if (n == 1)
            {
                return '0';
            }

            // Calculate the length of the string
            var len = (int)Math.Pow(2, n) - 1;

            // If k is half the length, return 1
            if (k == len / 2 + 1)
            {
                return '1';
            }

            // If k is less than half the length, return the kth bit
            if (k < len / 2 + 1)
            {
                return FindKthBit(n - 1, k);
            }

            // If k is greater than half the length, return the complement of the kth bit
            return FindKthBit(n - 1, len - k + 1) == '0' ? '1' : '0';
        }
    }
}
