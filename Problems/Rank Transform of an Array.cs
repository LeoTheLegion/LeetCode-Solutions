using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int[] ArrayRankTransform(int[] arr)
        {
            // Sort the array
            int[] sortedArr = arr.OrderBy(x => x).ToArray();

            Dictionary<int, int> rank = new Dictionary<int, int>();
            int r = 1;
            // Rank the array
            foreach (int num in sortedArr)
            {
                if (!rank.ContainsKey(num))
                {
                    rank[num] = r++;
                }
            }

            int[] result = new int[arr.Length];
            // Get the rank of each element
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = rank[arr[i]];
            }

            return result;
        }
    }
}
