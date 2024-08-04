using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public string IntToRoman(int num)
        {
            string s = "";

            //M
            while (num >= 1000)
            {
                num -= 1000;
                s += "M";
            }

            // D C
            while (num >= 100)
            {
                int x = num / 100;

                if (x == 9)
                {
                    s += "CM";
                    num -= 900;
                }
                else if (x >= 5)
                {
                    s += "D";
                    num -= 500;
                }
                else if (x == 4)
                {
                    s += "CD";
                    num -= 400;
                }
                else
                {
                    s += "C";
                    num -= 100;
                }
            }

            // L X
            while (num >= 10)
            {
                int x = num / 10;

                if (x == 9)
                {
                    s += "XC";
                    num -= 90;
                }
                else if (x >= 5)
                {
                    s += "L";
                    num -= 50;
                }
                else if (x == 4)
                {
                    s += "XL";
                    num -= 40;
                }
                else
                {
                    s += "X";
                    num -= 10;
                }
            }

            // V I
            while (num >= 1)
            {
                int x = num;

                if (x == 9)
                {
                    s += "IX";
                    num -= 9;
                }
                else if (x >= 5)
                {
                    s += "V";
                    num -= 5;
                }
                else if (x == 4)
                {
                    s += "IV";
                    num -= 4;
                }
                else
                {
                    s += "I";
                    num -= 1;
                }
            }


            return s;
        }
    }
}
