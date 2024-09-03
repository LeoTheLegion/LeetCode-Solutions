using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int x = 0;
            int y = 0;

            int x1 = obstacleGrid.Length - 1;
            int y1 = obstacleGrid[0].Length - 1;

            if (obstacleGrid[x][y] == 1 || obstacleGrid[x1][y1] == 1)
            {
                return 0;
            }

            // 1 == obstacle
            // 0 == empty
            //implement Depth First Search Algorithm
            return DFS(obstacleGrid, x, y, x1, y1);

            int DFS(int[][] grid, int x, int y, int x1, int y1)
            {
                if (x == x1 && y == y1)
                {
                    return 1;
                }

                if (grid[x][y] == -1)
                {
                    return 0;
                }

                if (grid[x][y] > 0)
                {
                    return grid[x][y];
                }

                int count = 0;

                if (x + 1 <= x1 && grid[x + 1][y] != 1)
                {
                    count += DFS(grid, x + 1, y, x1, y1);
                }

                if (y + 1 <= y1 && grid[x][y + 1] != 1)
                {
                    count += DFS(grid, x, y + 1, x1, y1);
                }

                grid[x][y] = count;

                return count;
            } 
        }
    }
}
