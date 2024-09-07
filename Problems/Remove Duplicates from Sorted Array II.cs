using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int RemoveDuplicates2(int[] nums)
        {
            int k = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                int x = nums[i];
                int y = (i + 1 < nums.Length) ? nums[i + 1] : int.MaxValue - 1;
                int z = (i + 2 < nums.Length) ? nums[i + 2] : int.MaxValue;
                if (x == y && y != z)
                {
                    nums[k++] = nums[i];
                }else if(x != y)
                {
                    nums[k++] = nums[i];
                }
            }

            return k;
        }
    }
}
