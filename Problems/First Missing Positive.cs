using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {

            Array.Sort(nums);

            int small = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                int t = nums[i];

                if (t < 1) continue;

                if (t != small) return small;

                small++;

                while (i < nums.Length - 1 && nums[i] == nums[i + 1])
                {
                    i++;
                }
            }

            return small;
        }
    }
}
