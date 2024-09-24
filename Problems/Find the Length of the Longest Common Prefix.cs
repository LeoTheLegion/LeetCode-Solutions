using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int LongestCommonPrefix(int[] arr1, int[] arr2)
        {
            // Find the longest common prefix of two arrays of integers
            HashSet<int> prefixes = new HashSet<int>(); 

            // Find all prefixes in the first array
            for(int i = 0; i < arr1.Length; i++)
            {
                int currentValue = arr1[i];
                while (currentValue > 0)
                {
                    prefixes.Add(currentValue);
                    currentValue /= 10;
                }
            }

            int maxPrefix = 0; 

            // Find the longest common prefix in the second array
            for(int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] < maxPrefix) continue;
                int currentValue = arr2[i];
                while (currentValue > 0)
                {
                    if (prefixes.Contains(currentValue) && currentValue > maxPrefix)
                    {
                        maxPrefix = currentValue;
                    }
                    currentValue /= 10;
                }
            }
            
            int maxPrefixLength = 0;
            // Find the length of the longest common prefix
            while (maxPrefix > 0)
            {
                maxPrefixLength++;
                maxPrefix /= 10;
            }

            return maxPrefixLength;
        }
    }
}
