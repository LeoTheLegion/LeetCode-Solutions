using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public long DividePlayers(int[] skill)
        {
            long sum = 0;
            int len = skill.Length;

            // find the sum of all the skills
            for (int i = 0; i < len; i++)
            {
                sum += skill[i];
            }

            // if the length of the array is 2,
            // return the product of the two elements
            if (len == 2)
            {
                return (long)skill[0] * skill[1];
            }

            // if the sum of all the skills is not divisible by len / 2,
            // return -1
            if (sum % (len / 2) != 0)
            {
                return -1;
            }

            // sort the array
            Array.Sort(skill);

            // find the target sum
            long targetSum = sum / (len / 2);
            long result = 0;

            // iterate through the first half of the array
            for (int i = 0; i < len / 2; i++)
            {
                int l = skill[i];
                int r = skill[len - 1 - i];

                // if the sum of the two elements is not equal to the target sum,
                // return -1
                if (l + r != targetSum)
                {
                    return -1;
                }

                // add the product of the two elements to the result
                result += (long)l * r;
            }

            return result;
        }
    }
}
