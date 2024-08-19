using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            if(divisor == 1)
            {
                return dividend;
            }

            // 0 for positive, -1 for negative
            int sign1 = (dividend >> 31);
            int sign2 = (divisor >> 31);

            int pSign = sign1 ^ sign2;

            bool dividendIsMin = dividend == int.MinValue;

            if (dividendIsMin)
            {
                dividend = int.MaxValue;
            }
            else
            {
                dividend = (dividend ^ sign1) - sign1;
            }

            bool divisorIsMin = divisor == int.MinValue;

            if (divisorIsMin)
            {
                divisor = int.MaxValue;
            }
            else
            {
                divisor = (divisor ^ sign2) - sign2;
            }

            int p = 0;

            if (divisor == 1)
            {
                p = dividend;
            }
            else
            {
                if(dividend < divisor)
                {
                    return 0;
                }

                if(dividendIsMin && dividend >= divisor)
                {
                    dividend -= divisor;
                    p++;
                    dividend += 1;
                }else if( divisorIsMin && dividend >= divisor)
                {
                    dividend -= divisor;
                    dividend -= 1;

                    if(dividend > 0)
                    {
                        p++;
                    }
                }


                while (dividend >= divisor)
                {
                    dividend -= divisor;
                    p++;
                }
            }
            if (pSign == -1) return -p;
            return p;
        }
    }
}
