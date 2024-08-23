using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;

            if (l == r && nums[l] == target)
                return new int[] { 0, 0 };

            while (l < r)
            {
                if (nums[l] < target)
                {
                    l++;
                }

                if (nums[r] > target)
                {
                    r--;
                }

                if (nums[l] == nums[r] && nums[l] == target)
                {
                    return new int[] { l, r };
                }
            }

            return new int[] { -1, -1 };
        }
    }
}
