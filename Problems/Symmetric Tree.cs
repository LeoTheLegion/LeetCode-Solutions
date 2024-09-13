using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            return IsSymmetric(root, root);

            bool IsSymmetric(TreeNode left, TreeNode right)
            {
                if (left == null && right == null)
                {
                    return true;
                }

                if (left == null || right == null)
                {
                    return false;
                }

                if (left.val != right.val)
                {
                    return false;
                }

                if (!IsSymmetric(left.left, right.right))
                {
                    return false;
                }

                if (!IsSymmetric(left.right, right.left))
                {
                    return false;
                }

                return true;
            }
        }
    }
}
