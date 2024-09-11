using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            InorderTraversal(root, result);
            return result;

            void InorderTraversal(TreeNode node, List<int> result)
            {
                if (node == null)
                {
                    return;
                }

                InorderTraversal(node.left, result);
                result.Add(node.val);
                InorderTraversal(node.right, result);
            }

        }
    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
