using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public bool CanArrange(int[] arr, int k)
        {
            Dictionary<int, int> remainderCounts = new Dictionary<int, int>();

            // Count the remainders
            foreach (int num in arr)
            {
                int remainder = ((num % k) + k) % k; // Handle negative numbers
                if (!remainderCounts.ContainsKey(remainder))
                {
                    remainderCounts[remainder] = 0;
                }
                remainderCounts[remainder]++;
            }

            // Check if pairs can be formed
            foreach (var kvp in remainderCounts)
            {
                int remainder = kvp.Key;
                int count = kvp.Value;

                if (remainder == 0)
                {
                    // For remainder 0, count must be even
                    if (count % 2 != 0)
                    {
                        return false;
                    }
                }
                else
                {
                    int complement = k - remainder;
                    if (!remainderCounts.ContainsKey(complement) || remainderCounts[complement] != count)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
