using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int MaximumSwap(int num)
        { 
            // Convert the number to a string
            var numStr = num.ToString();
            // Convert the string to a character array
            var numArr = numStr.ToCharArray();
            // Create an array to store the last index of each digit
            var last = new int[10];

            // Store the last index of each digit
            for (int i = 0; i < numArr.Length; i++)
            {
                last[numArr[i] - '0'] = i;
            }

            // Iterate through the digits
            for (int i = 0; i < numArr.Length; i++)
            {
                // Iterate through the digits from 9 to the current digit
                for (int d = 9; d > numArr[i] - '0'; d--)
                {
                    // If the last index of the digit is greater
                    // than the current index
                    if (last[d] > i)
                    {
                        // Swap the digits
                        var temp = numArr[i];
                        numArr[i] = numArr[last[d]];
                        numArr[last[d]] = temp;

                        // Convert the character array to a string
                        // and then to an integer
                        return int.Parse(new string(numArr));
                    }
                }
            }
            // else return the number
            return num;
        }
    }
}
