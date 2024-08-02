using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {

            int longest = 0;

            HashSet<char> discoveredChars = new HashSet<char>();
            int last = 0;
            bool subHunting = false;

            for (int i = 0; i < s.Length; i++)
            {
                char curr = s[i];

                bool added = discoveredChars.Add(curr);

                if (!added)
                {
                    int count = discoveredChars.Count;

                    if (count > longest)
                    {
                        longest = count;
                    }

                    discoveredChars.Clear();

                    i = last;
                    subHunting = false;
                }
                else
                {
                    if (!subHunting)
                    {
                        subHunting = true;
                        last = i;
                    }
                }
            }

            if (discoveredChars.Count > longest)
            {
                return discoveredChars.Count;
            }

            return longest;
        }
    }
}
