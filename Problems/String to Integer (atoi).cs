using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int MyAtoi(string s)
        {
            short sign = 1;

            int sum = 0;
            ushort j = 0;

            bool readingNum = false;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                int code = c;

                if (code == 32 && !readingNum) // space
                    continue;

                if (code == 45 && sign == 1)
                {// negative
                    if (readingNum)
                    {
                        break;
                    }
                    sign = -1;
                    readingNum = true;
                    continue;
                }

                if (code == 43)
                {
                    if (readingNum)
                    {
                        break;
                    }
                    sign = 1;
                    readingNum = true;
                    continue;
                }

                int c_num = code - 48;
                //return c_num;

                if (c_num < 0 || c_num > 9)// is number
                    break;

                try
                {
                    sum = checked(c_num + sum * 10);
                }
                catch (OverflowException ex)
                {
                    sum = int.MaxValue;

                    if (sign == -1)
                    {
                        sum += 1;
                    }

                    break;
                }

                readingNum = true;
                if (sum != 0)
                {
                    j++;
                }
            }

            return sum * sign;
        }
    }
}
