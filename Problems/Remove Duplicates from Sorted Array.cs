using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {

            int k = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int n1 = nums[i];
                int n2 = nums[i + 1];

                if (n1 < n2)
                {
                    nums[k] = n1;
                    k++;
                }
            }

            if (k < nums.Length)
            {
                nums[k] = nums[nums.Length - 1];
                k++;
            }

            return k;
        }
    }
}
