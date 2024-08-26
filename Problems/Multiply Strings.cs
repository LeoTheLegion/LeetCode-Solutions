using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";

            if (num1.Length < num2.Length)
                return Multiply(num2, num1);

            //Do the multiplication

            int product = 0;

            for (int i = num2.Length - 1; 0 <= i; i--)
            {
                int y = num2[i] - '0';

                int carry = 0;

                int innerSum = 0;

                for (int j = num1.Length - 1; 0 <= j; j--)
                {
                    int x = num1[j] - '0';

                    int k = x * y + carry;
                    carry = k / 10;
                    k = k % 10;

                    innerSum += k * (int)Math.Pow(10, num1.Length - 1 - j);
                }

                innerSum += carry * (int)Math.Pow(10, num1.Length);

                product += innerSum * (int)Math.Pow(10, num2.Length - 1 - i);
            }

            //Convert the product to string

            string result = "";

            while (product > 0)
            {
                char c = (char)(product % 10 + '0');
                result = c + result;
                product /= 10;
            }

            return result;
        }
    }
}
