using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length <= 1)
                return intervals;

            //sort by first element
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            List<int[]> list = new List<int[]>();

            for (int i = 0; i < intervals.Length; i++)
            {
                int min1 = intervals[i][0];
                int max1 = intervals[i][1];

                int min2 = (i < intervals.Length - 1) ? intervals[i + 1][0] : Int32.MaxValue;
                int max2 = (i < intervals.Length - 1) ? intervals[i + 1][1] : Int32.MaxValue;

                if (max1 < min2)
                {
                    list.Add(intervals[i]);
                    continue;
                }

                //merge intervals
                while (min2 <= max1 && i < intervals.Length - 1)
                {
                    min1 = Math.Min(min1, min2);
                    max1 = Math.Max(max1, max2);
                    i++;
                    min2 = (i < intervals.Length - 1) ? intervals[i + 1][0] : Int32.MaxValue;
                    max2 = (i < intervals.Length - 1) ? intervals[i + 1][1] : Int32.MaxValue;
                }

                list.Add(new int[] { min1, max1 });
            }

            return list.ToArray();
        }
    }
}
