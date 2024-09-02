using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int UniquePaths(int m, int n)
        {
            int[] grid = new int[m * n];

            int start = 0;
            int end = grid.Length - 1;

            //implement Depth First Search Algorithm
            return DFS(grid, m, n, start, end);

            int DFS(int[] grid, int m, int n, int start, int end)
            {
                if (start == end)
                {
                    return 1;
                }

                if (grid[start] > 0)
                {
                    return grid[start];
                }

                int count = 0;

                if (start + 1 < m * n && (start + 1) % m != 0)
                {
                    count += DFS(grid, m, n, start + 1, end);
                }

                if (start + m < m * n)
                {
                    count += DFS(grid, m, n, start + m, end);
                }

                grid[start] = count;

                return count;
            }
        }
    }
}
