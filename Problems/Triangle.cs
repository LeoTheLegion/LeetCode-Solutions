using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{    public partial class Solution
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int n = triangle.Count;
            
            // Create a 1D array to store the minimum path sum from the bottom to the current row
            int[] dp = new int[n + 1];

            // Start from the bottom
            for (int i = n - 1; i >= 0; i--)
            {
                // For each element in the row, find the minimum path sum
                for (int j = 0; j <= i; j++)
                {
                    // The current element
                    var current = triangle[i][j];

                    // The minimum of the two adjacent elements
                    var min = Math.Min(dp[j], dp[j + 1]);

                    // The minimum path sum from the bottom to the current row i
                    dp[j] = current + min;
                }
            }

            // The minimum path sum from the top to the bottom
            return dp[0];
        }
    }
}
