using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0] && i + needle.Length <= haystack.Length)
                {

                    bool found = true;

                    for (int j = 1; j < needle.Length; j++)
                    {
                        if (haystack[i + j] != needle[j])
                        {
                            found = false;
                            break;
                        }
                    }

                    if (found)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
