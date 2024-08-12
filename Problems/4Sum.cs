using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {

            Array.Sort(nums);

            List<IList<int>> outputs = new List<IList<int>>();

            int start4 = 0;

            while (start4 < nums.Length - 3)
            {

                int start3 = start4 + 1;

                while (start3 < nums.Length - 2)
                {

                    int l = start3 + 1;
                    int r = nums.Length - 1;

                    int sum;

                    try
                    {
                        checked
                        {
                            sum = target - nums[start4] - nums[start3];
                        }
                    }
                    catch (OverflowException ex)
                    {
                        start3++;
                        continue;
                    }

                    while (l < r)
                    {
                        int opps = nums[l] + nums[r];

                        if (opps == sum)
                        {
                            //solution

                            List<int> sol = new List<int>(){
                            nums[start4],
                            nums[start3],
                            nums[l],
                            nums[r]};

                            outputs.Add(sol);

                            while (l < r && nums[l] == sol[2])
                                l++;

                            while (l < r && nums[r] == sol[3])
                                r--;

                        }
                        else if (opps < sum)
                        {
                            l++;
                        }
                        else if (opps > sum)
                        {
                            r--;
                        }
                    }

                    int curr3 = nums[start3];

                    while (start3 < nums.Length - 2 && curr3 == nums[start3])
                    {
                        start3++;
                    }
                }


                int curr4 = nums[start4];

                while (start4 < nums.Length - 3 && curr4 == nums[start4])
                {
                    start4++;
                }
            }

            return outputs;
        }
    }
}
