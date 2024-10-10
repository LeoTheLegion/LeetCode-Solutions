using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int MaxWidthRamp(int[] nums)
        {
            int n = nums.Length;
            int[] min = new int[n];
            int[] max = new int[n];

            min[0] = nums[0];
            // Find the minimum element from the left
            for (int i = 1; i < n; i++)
            {
                min[i] = Math.Min(min[i - 1], nums[i]);
            }

            max[n - 1] = nums[n - 1];
            // Find the maximum element from the right
            for (int i = n - 2; i >= 0; i--)
            {
                max[i] = Math.Max(max[i + 1], nums[i]);
            }

            int i1 = 0;
            int i2 = 0;
            int maxDiff = 0;
            // Find the maximum difference between the minimum and maximum element
            while (i1 < n && i2 < n)
            {
                if (min[i1] <= max[i2])
                {
                    // Update the maximum difference
                    maxDiff = Math.Max(maxDiff, i2 - i1);
                    i2++;
                }
                else
                {
                    i1++;
                }
            }

            return maxDiff;
        }
    }
}
