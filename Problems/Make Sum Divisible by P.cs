using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int MinSubarray(int[] nums, int p)
        {
            int n = nums.Length;
            long sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }

            long target = sum % p;
            if (target == 0)
            {
                return 0;
            }

            Dictionary<long, int> map = new Dictionary<long, int>();
            map[0] = -1;
            long prefixSum = 0;
            int result = n;
            for (int i = 0; i < n; i++)
            {
                prefixSum += nums[i];
                long remainder = prefixSum % p;
                long complement = (remainder - target + p) % p;
                if (map.ContainsKey(complement))
                {
                    result = Math.Min(result, i - map[complement]);
                }

                map[remainder] = i;
            }

            return result == n ? -1 : result;
        }
    }
}
