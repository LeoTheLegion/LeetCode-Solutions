using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);

            IList<IList<int>> outputs = new List<IList<int>>();

            int start = 0;

            while (start < nums.Length - 2)
            {

                int l = start + 1;
                int r = nums.Length - 1;
                int sum = nums[start] * -1;

                while (l < r)
                {

                    int opps = nums[l] + nums[r];

                    if (opps == sum)
                    {
                        List<int> sol = new List<int>([nums[start], nums[l], nums[r]]);
                        outputs.Add(sol);

                        while (l < r && nums[l] == sol[1])
                            l++;
                        while (l < r && nums[r] == sol[2])
                            r--;

                    }
                    else if (opps > sum)
                    {
                        r--;
                    }
                    else if (opps < sum)
                    {
                        l++;
                    }
                }

                while (start < nums.Length && nums[start] == sum * -1)
                {
                    start++;
                }
            }

            return outputs;
        }
    }
}
