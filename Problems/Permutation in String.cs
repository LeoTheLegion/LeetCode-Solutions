using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public bool CheckInclusion(string s1, string s2)
        {
            // If s1 is longer than s2,
            // it can't be a permutation of s2
            if (s1.Length > s2.Length) return false;


            // Initialize the count arrays
            int[] s1Count = new int[26];
            int[] s2Count = new int[26];

            // Count the frequency of each character in s1
            foreach (char c in s1)
            {
                s1Count[c - 'a']++;
            }

            // Initialize the first window in s2
            for (int i = 0; i < s1.Length; i++)
            {
                s2Count[s2[i] - 'a']++;
            }

            // Check if the first window is a permutation of s1
            if (AreCountsEqual(s1Count, s2Count)) return true;

            // Slide the window over s2
            for (int i = s1.Length; i < s2.Length; i++)
            {
                // Update the count arrays
                s2Count[s2[i] - 'a']++;
                s2Count[s2[i - s1.Length] - 'a']--;

                if (AreCountsEqual(s1Count, s2Count)) return true;
            }

            return false;

            bool AreCountsEqual(int[] s1Count, int[] s2Count)
            {
                // Check if the count arrays are equal
                for (int i = 0; i < 26; i++)
                {
                    if (s1Count[i] != s2Count[i]) return false;
                }
                return true;
            }
        }
    }
}
