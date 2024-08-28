using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int[] PlusOne(int[] digits)
        {

            bool carry = true;

            for (int i = digits.Length - 1; 0 <= i; i--)
            {
                if (carry)
                {
                    digits[i] += 1;
                }

                if (digits[i] > 9)
                {
                    digits[i] -= 10;
                }
                else
                {
                    carry = false;
                    break;
                }
            }

            if (carry)
            {
                int[] newD = new int[digits.Length + 1];
                newD[0] = 1;

                for (int i = 0; i < digits.Length; i++)
                {
                    newD[i + 1] = digits[i];
                }

                return newD;
            }

            return digits;
        }
    }
}
