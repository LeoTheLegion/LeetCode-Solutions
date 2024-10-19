using System;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int CountMaxOrSubsets(int[] nums)
        {
            int maxOr = 0;
            foreach (var num in nums)
            {
                maxOr |= num;
            }

            return CountSubsets(nums, 0, 0, maxOr);

            int CountSubsets(int[] nums, int index, int currentOr, int maxOr)
            {
                if (index == nums.Length)
                {
                    return currentOr == maxOr ? 1 : 0;
                }

                // Include the current element in the subset
                int include = CountSubsets(nums, index + 1, currentOr | nums[index], maxOr);

                // Exclude the current element from the subset
                int exclude = CountSubsets(nums, index + 1, currentOr, maxOr);

                return include + exclude;
            }
        }
    }
}
