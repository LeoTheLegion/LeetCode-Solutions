using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int MaxUniqueSplit(string s)
        {
            return MaxUniqueSplit(s, 0, new HashSet<string>());

            int MaxUniqueSplit(string s, int start, HashSet<string> set)
            {
                // If we reached the end of the string,
                // return the count of unique substrings
                if (start == s.Length)
                {
                    return set.Count;
                }

                var max = 0;

                // Try to split at each position
                for (var i = start + 1; i <= s.Length; i++)
                {
                    // Get the substring
                    var sub = s.Substring(start, i - start);
                    // Check if the substring is unique
                    if (set.Add(sub))
                    {
                        // Recursively try to split the rest of the string
                        max = Math.Max(max, MaxUniqueSplit(s, i, set));
                        // Remove the substring from the set
                        set.Remove(sub);
                    }
                }

                return max;
            }
        }
    }
}
