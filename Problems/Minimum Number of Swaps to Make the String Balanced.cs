using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int MinSwaps(string s)
        {
            int balance = 0;
            int maxImbalance = 0;

            // Count the number of opening brackets
            // minus the number of closing brackets
            foreach (char c in s)
            {
                if (c == '[')
                {
                    balance++;
                }
                else
                {
                    balance--;
                }

                // Track the maximum imbalance
                if (balance < 0)
                {
                    // The maximum imbalance is the maximum number of closing brackets
                    maxImbalance = Math.Max(maxImbalance, -balance);
                }
            }

            // The minimum number of swaps needed is half of the maximum imbalance
            return (maxImbalance + 1) / 2;
        }
    }
}
