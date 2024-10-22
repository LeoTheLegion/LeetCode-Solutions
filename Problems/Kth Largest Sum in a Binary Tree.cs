using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public long KthLargestLevelSum(TreeNode root, int k)
        {
            //We need to track all the sums in each level
            Dictionary<int, long> sums = new Dictionary<int, long>();

            //Update sums dictionary and return the length
            int length = UpdateSums(root, 0, sums);

            //If there are fewer than k levels in the tree, return -1
            if (length < k) return -1;

            //We need to gather all the sums and sort them
            long[] sort = new long[length];
            for (int i = 0; i < sort.Length; i++)
            {
                sort[i] = sums[i];
            }
            Array.Sort(sort);

            //Return the kth largest level sum in the tree 
            return sort[length - k];

            int UpdateSums(TreeNode node, int level, Dictionary<int, long> sums)
            {
                //We are at the end,
                //return the length
                if (node == null) return level;

                int value = node.val;

                //if this is the first time,
                //reaching this level,
                //make some room
                if (!sums.ContainsKey(level))
                {
                    sums[level] = value;
                }
                else
                { // or add to previous value
                    sums[level] += value;
                }

                //Return max Length from both sides
                return Math.Max(
                    //Explore left side
                    UpdateSums(node.left, level + 1, sums),
                    //Explore right side
                    UpdateSums(node.right, level + 1, sums)
                );
            }
        }
    }
}
