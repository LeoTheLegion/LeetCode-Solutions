using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int MaxArea(int[] height)
        {

            int MaxArea = 0;

            int l = 0;
            int r = height.Length - 1;

            while (l < r)
            {
                bool leftHeavy = (height[l] > height[r]);
                int minHeight = (leftHeavy) ? height[r] : height[l];

                int area = minHeight * (r - l);

                if (MaxArea < area)
                {
                    MaxArea = area;
                }

                if (leftHeavy)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }

            return MaxArea;
        }
    }
}
