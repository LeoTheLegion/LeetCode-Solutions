using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            // Find all the starting points of the word
            List<int> start = new List<int>();

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        start.Add(i * board[i].Length + j);
                    }
                }
            }
            // DFS from each starting point
            for(int i = 0; i < start.Count; i++)
            {
                if (DFS(board, word, 0, start[i] / board[0].Length, start[i] % board[0].Length))
                {
                    start.Clear();
                    return true;
                }
            }
            start.Clear();
            return false;

            // Depth First Search
            bool DFS(char[][] board, string word, int index, int i, int j)
            {
                // If we have reached the end of the word, return true
                if (index == word.Length)
                {
                    return true;
                }
                // If we are out of bounds, return false
                if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length)
                {
                    return false;
                }
                // If the current character does not match the current character in the word, return false
                if (board[i][j] != word[index])
                {
                    return false;
                }

                // Temporarily set the current character to empty space to avoid revisiting it
                char temp = board[i][j];
                board[i][j] = ' ';

                // Recursively search for the next character in the word
                bool result = DFS(board, word, index + 1, i + 1, j) ||
                              DFS(board, word, index + 1, i - 1, j) ||
                              DFS(board, word, index + 1, i, j + 1) ||
                              DFS(board, word, index + 1, i, j - 1);

                // Reset the current character
                board[i][j] = temp;

                return result;
            }
        }
    }
}
