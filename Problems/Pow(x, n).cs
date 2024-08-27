using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public double MyPow(double x, int n)
        {

            if (n == Int32.MinValue)
            {
                n = -(n + 1);
                x = 1 / x;
                return x * x * MyPow(x * x, n / 2);
            }

            if (n == 0)
                return 1;

            if (n == 1)
            {
                return x;
            }

            if (n < 0)
            { // revert x if n is negative
                x = 1 / x;
                n = -n;
            }

            if (n % 2 == 0)
            {
                double y = MyPow(x, n / 2);
                return y * y;
            }
            else
            {
                double y = MyPow(x, (n - 1) / 2);
                return y * y * x;
            }
        }
    }
}
