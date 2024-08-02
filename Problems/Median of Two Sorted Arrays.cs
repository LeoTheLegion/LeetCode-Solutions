using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] main = new int[nums1.Length + nums2.Length];

            Array.Copy(nums1, main, nums1.Length);
            Array.Copy(nums2, 0, main, nums1.Length, nums2.Length);

            Array.Sort(main);

            int length = main.Length;

            float halfLength = (float)(length - 1) / 2f;

            int i_1 = (int)Math.Floor(halfLength);
            int i_2 = (int)Math.Ceiling(halfLength);

            return (double)(main[i_1] + main[i_2]) / 2.0;
        }
    }
}
