using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public void SortColors(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int i = 0;

            while (i <= right)
            {
                // If the current element is 0, swap it with the left element
                if (nums[i] == 0)
                {
                    Swap(nums, i, left);
                    left++;
                    i++;
                }
                // If the current element is 2, swap it with the right element
                else if (nums[i] == 2)
                {
                    Swap(nums, i, right);
                    right--;
                }
                else
                {
                    i++;
                }
            }

            void Swap(int[] arr, int i, int j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}
