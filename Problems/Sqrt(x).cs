using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int MySqrt(int x)
        {
            if (x <= 1) return x;

            double approx = x / 2;

            while (approx * approx - x > 0.5)
            {
                approx = (approx + x / approx) / 2;
            }
            return (int)approx;
        }
    }
}
