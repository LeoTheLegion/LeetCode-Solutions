using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);

            int start = 0;

            int closest = Int32.MaxValue;

            while (start < nums.Length - 2)
            {

                int l = start + 1;
                int r = nums.Length - 1;
                int sum = nums[start] * -1;

                while (l < r)
                {
                    int leftVal = nums[l];
                    int rightVal = nums[r];

                    int temp = nums[start] + leftVal + rightVal;

                    if (temp == target)
                        return temp;
                    else
                    {
                        int x = Math.Abs(target - closest);
                        int y = Math.Abs(target - temp);

                        if (y < x)
                        {
                            closest = temp;
                        }
                    }

                    if (temp > target)
                    {
                        r--;
                    }
                    else if (temp < target)
                    {
                        l++;
                    }

                }

                start++;
            }

            return closest;
        }
    }
}
