using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                string hash;

                char[] c = strs[i].ToCharArray();
                Array.Sort(c);

                hash = new string(c);

                if (!dict.ContainsKey(hash))
                {
                    dict[hash] = new List<string>();
                }

                dict[hash].Add(strs[i]);
            }

            return dict.Values.ToList<IList<string>>();
        }
    }
}
