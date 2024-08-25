using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int Trap(int[] height)
        {

            int sum = 0;

            int l = 0;
            int r = height.Length - 1;

            while (height[l] <= 0 && l < r)
            {
                l++;
            }

            while (height[r] <= 0 && l < r)
            {
                r--;
            }

            if (l == r)
            {
                return 0;
            }

            for (int i = l; i <= r; i++)
            {
                if (height[i] > 0)
                {
                    height[i] -= 1;
                    continue;
                }
                sum++;
            }

            return sum + Trap(height);
        }
    }
}
