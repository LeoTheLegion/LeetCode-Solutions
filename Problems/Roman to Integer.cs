using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int RomanToInt(string s)
        {

            if (s.Length == 0)
                return 0;

            char c1 = s[0];
            char c2 = (s.Length > 1) ? s[1] : ' ';

            //2000 overengineering
            if (c1 == 'M' && c2 == 'M') return 2000 + RomanToInt(s.Substring(2, s.Length - 2));

            //1000
            if (c1 == 'M') return 1000 + RomanToInt(s.Substring(1, s.Length - 1));

            //900
            if (c1 == 'C' && c2 == 'M') return 900 + RomanToInt(s.Substring(2, s.Length - 2));

            //500
            if (c1 == 'D') return 500 + RomanToInt(s.Substring(1, s.Length - 1));

            //400
            if (c1 == 'C' && c2 == 'D') return 400 + RomanToInt(s.Substring(2, s.Length - 2));

            //200 overengineering
            if (c1 == 'C' && c2 == 'C') return 200 + RomanToInt(s.Substring(2, s.Length - 2));

            //100
            if (c1 == 'C') return 100 + RomanToInt(s.Substring(1, s.Length - 1));

            //90
            if (c1 == 'X' && c2 == 'C') return 90 + RomanToInt(s.Substring(2, s.Length - 2));

            //50
            if (c1 == 'L') return 50 + RomanToInt(s.Substring(1, s.Length - 1));

            //40
            if (c1 == 'X' && c2 == 'L') return 40 + RomanToInt(s.Substring(2, s.Length - 2));

            //20 overengineering
            if (c1 == 'X' && c2 == 'X') return 20 + RomanToInt(s.Substring(2, s.Length - 2));

            //10
            if (c1 == 'X') return 10 + RomanToInt(s.Substring(1, s.Length - 1));

            //9
            if (c1 == 'I' && c2 == 'X') return 9 + RomanToInt(s.Substring(2, s.Length - 2));

            //5
            if (c1 == 'V') return 5 + RomanToInt(s.Substring(1, s.Length - 1));

            //4
            if (c1 == 'I' && c2 == 'V') return 4 + RomanToInt(s.Substring(2, s.Length - 2));

            //2 overengineering
            if (c1 == 'I' && c2 == 'I') return 2 + RomanToInt(s.Substring(2, s.Length - 2));

            //1
            if (c1 == 'I') return 1 + RomanToInt(s.Substring(1, s.Length - 1));

            return 0;
        }
    }
}
