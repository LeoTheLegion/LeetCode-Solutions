using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            // Get the length of the matrix as a 1D array
            int len = matrix.Length * matrix[0].Length;

            // Binary search
            int left = 0;
            int right = len - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                /// Get the x and y coordinates of the mid element
                int x = mid / matrix[0].Length;
                int y = mid % matrix[0].Length;

                // Get the value of the mid element
                int midVal = matrix[x][y];

                // If the mid element is the target, return true
                if (midVal == target)
                {
                    return true;
                }

                // If the mid element is less than the target, search the right half
                if (midVal < target)
                {
                    left = mid + 1;
                }
                // If the mid element is greater than the target, search the left half
                else
                {
                    right = mid - 1;
                }
            }

            // If the target is not found, return false
            return false;
        }
    }
}
