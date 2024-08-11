using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0)
                return new List<string>();

            var numToChars = new Dictionary<char, string[]>(){
            {'2', new string[]{"a","b","c"}},
            {'3', new string[]{"d","e","f"}},
            {'4', new string[]{"g","h","i"}},
            {'5', new string[]{"j","k","l"}},
            {'6', new string[]{"m","n","o"}},
            {'7', new string[]{"p","q","r","s"}},
            {'8', new string[]{"t","u","v"}},
            {'9', new string[]{"w","x","y","z"}}
        };

            string[] arr = numToChars[digits[0]];

            for (int i = 1; i < digits.Length; i++)
            {
                string[] num = numToChars[digits[i]];

                string[] temp = new string[arr.Length * num.Length];

                for (int j = 0; j < temp.Length; j++)
                {
                    int x = j % arr.Length;
                    int y = j / arr.Length;

                    temp[x + y * arr.Length] = arr[x] + num[y];
                }

                arr = temp;
            }

            return new List<string>(arr);
        }
    }
}
