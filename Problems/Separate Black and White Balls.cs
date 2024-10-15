using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public long MinimumSteps(string s)
        {
            long steps = 0;
            int l = 0;
            int r = s.Length - 1;

            while (l < r)
            {
                //Move the left pointer for 0s
                if (s[l] == '0')
                    l++;
                //Move the right point for 1s
                else if (s[r] == '1')
                    r--;
                //If we fail to move the pointers
                //then we should swap them.
                //Add the distance between the pointer
                //to the steps
                else
                {
                    step += r - l;

                    l++;
                    r--;
                }
            }

            return steps;
        }
    }
}
