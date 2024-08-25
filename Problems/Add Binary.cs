using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public string AddBinary(string a, string b)
        {

            int a_len = a.Length;
            int b_len = b.Length;

            if (b_len > a_len)
            {
                return AddBinary(b, a);
            }

            int carry = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < a_len; i++)
            {
                int a_bit = a[a_len - 1 - i] - '0';
                int b_bit = i < b_len ? b[b_len - 1 - i] - '0' : 0;

                int sum = a_bit + b_bit + carry;

                carry = sum / 2;

                sb.Insert(0, sum % 2);
            }

            if (carry > 0)
            {
                sb.Insert(0, carry);
            }

            return sb.ToString();
        }
    }
}
