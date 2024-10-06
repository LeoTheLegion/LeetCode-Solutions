using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        /*
         *You are given two strings sentence1 and sentence2,
         *each representing a sentence composed of words. 
         *A sentence is a list of words that are separated by a single space
         *with no leading or trailing spaces. Each word consists of only
         *uppercase and lowercase English characters.

         * Two sentences s1 and s2 are considered similar if it is 
         * possible to insert an arbitrary sentence (possibly empty)
         * inside one of these sentences such that the two sentences 
         * become equal. Note that the inserted sentence must be
         * separated from existing words by spaces. 
         * 
         */
        public bool AreSentencesSimilar(string sentence1, string sentence2)
        {
            // Split the strings into words
            string[] s1 = sentence1.Split(' ');
            string[] s2 = sentence2.Split(' ');

            // If s1 is longer than s2,
            // flip the strings
            if (s1.Length < s2.Length)
            {
                return AreSentencesSimilar(sentence2, sentence1);
            }

            int i = 0;
            int j = 0;

            // Skip the common prefix
            while (i < s1.Length && j < s2.Length && s1[i] == s2[j])
            {
                i++;
                j++;
            }

            // Skip the common suffix
            while (i < s1.Length && j < s2.Length && s1[s1.Length - 1] == s2[s2.Length - 1])
            {
                s1 = s1.Take(s1.Length - 1).ToArray();
                s2 = s2.Take(s2.Length - 1).ToArray();
            }

            // Check if the remaining strings are equal
            return i == s1.Length || j == s2.Length;
        }
    }
}
