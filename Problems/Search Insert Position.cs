using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {

            int l = 0;
            int r = nums.Length - 1;

            if (target < nums[l]) return 0;

            if (nums[r] < target) return l + 1;

            while (l < r)
            {
                int mid = (l + r) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return l;
        }
    }
}
