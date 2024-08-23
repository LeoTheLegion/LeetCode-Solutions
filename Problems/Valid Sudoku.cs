using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {

            int size = board.Length;
            int subSize = board.Length / 3;

            HashSet<char>[] colCheck = new HashSet<char>[size];
            HashSet<char>[] subCheck = new HashSet<char>[size];


            for (int i = 0; i < colCheck.Length; i++)
            {
                colCheck[i] = new HashSet<char>();
                subCheck[i] = new HashSet<char>();
            }

            HashSet<char> rowCheck = new HashSet<char>();

            for (int y = 0; y < size; y++)
            {
                rowCheck.Clear();
                for (int x = 0; x < size; x++)
                {

                    char c = board[y][x];

                    if (c == '.') continue;

                    if (!rowCheck.Add(c))
                        return false;

                    if (!colCheck[x].Add(c))
                        return false;

                    int xc = x / subSize;
                    int yc = y / subSize;

                    int ic = yc * subSize + xc;

                    if (!subCheck[ic].Add(c))
                        return false;
                }
            }

            return true;
        }
    }
}
