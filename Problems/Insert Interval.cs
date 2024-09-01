using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            if (intervals.Length == 0)
            {
                return new int[][] { newInterval };
            }

            List<int[]> list = new List<int[]>();

            int i_min = newInterval[0];
            int i_max = newInterval[1];

            //if new interval is less than the first interval
            if(i_max < intervals[0][0])
            {
                list.Add(newInterval);

                for (int i = 0; i < intervals.Length; i++)
                {
                    list.Add(intervals[i]);
                }

                return list.ToArray();
            }

            //if new interval is greater than the last interval
            if (i_min > intervals[intervals.Length - 1][1])
            {
                for (int i = 0; i < intervals.Length; i++)
                {
                    list.Add(intervals[i]);
                }

                list.Add(newInterval);

                return list.ToArray();
            }

            int l = 0;
            int r = intervals.Length - 1;

            //find the first interval that overlaps with the new interval
            //find the last interval that overlaps with the new interval
            while (l <= r)
            {
                int k = 0;

                int l_min = intervals[l][0];
                int l_max = intervals[l][1];

                if (l_max < i_min)
                {
                    list.Add(intervals[l]);
                    l++;
                }
                else
                {
                    k++;
                }

                int r_min = intervals[r][0];
                int r_max = intervals[r][1];

                if (i_max < r_min)
                {
                    //list.Add(intervals[r]);
                    r--;
                }
                else
                {
                    k++;
                }

                if (k == 2) break;
            }

            //overlap found
            if (l != r + 1)
            {
                //if new interval is less than the left interval
                if(i_max < intervals[l][0])
                {
                    list.Add(newInterval);
                    r--;
                }
                else //overlap them
                {
                    int new_min = (int)Math.Min(intervals[l][0], i_min);
                    int max_min = (int)Math.Max(intervals[r][1], i_max);

                    list.Add(new int[] { new_min, max_min });
                }
            }
            else //no overlap
            {
                list.Add(newInterval);
            }

            //add the remaining of the intervals
            for (int i = r + 1; i < intervals.Length; i++)
            {
                list.Add(intervals[i]);
            }


            return list.ToArray();
        }
    }
}
