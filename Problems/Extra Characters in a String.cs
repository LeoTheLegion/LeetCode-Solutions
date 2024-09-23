using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int MinExtraChar(string s, string[] dictionary)
        {
            // Get the length of the input word and the dictionary
            int inputWordLength = s.Length;
            int DicLength = dictionary.Length;

            // dp[i] is the minimum number of extra characters needed to form the first i characters of s
            int[] dp = new int[inputWordLength + 1];
            // Initialize dp
            dp[0] = 0;
            // Calculate dp
            for (int i = 1; i <= inputWordLength; i++)
            {
                // Initialize dp[i] to be dp[i - 1] + 1
                dp[i] = dp[i - 1] + 1;
                // Check if we can form a word from the dictionary
                for (int j = 0; j < DicLength; j++)
                {
                    // Get the length of the word
                    int wordLength = dictionary[j].Length;

                    // If the word is longer than i, skip it
                    if(wordLength > i)
                        continue;

                    // Get the substring of s that ends at i
                    var sub = s.Substring(i - wordLength, wordLength);

                    // If the substring is not the same as the word, skip it
                    if(sub != dictionary[j])
                        continue;

                    // Update dp[i] to be the minimum of dp[i] and dp[i - wordLength]
                    dp[i] = Math.Min(dp[i], dp[i - wordLength]);
                }
            }
            // Return the result
            return dp[inputWordLength];
        }
    }
}
