using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {

            List<int> outs = new List<int>(2);

            for (int i = 0; i < nums.Length; i++)
            {

                int x = nums[i];

                for (int j = i + 1; j < nums.Length; j++)
                {

                    int y = nums[j];

                    int r = x + y;

                    if (r != target)
                        continue;

                    outs.Add(i);
                    outs.Add(j);
                }
            }

            return outs.ToArray();
        }
    }
}
