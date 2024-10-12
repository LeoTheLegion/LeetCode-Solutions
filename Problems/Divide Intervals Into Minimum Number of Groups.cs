using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int MinGroups(int[][] intervals)
        {
            // Sort the intervals by the start time
            Array.Sort(intervals, (a, b) => a[0] - b[0]);

            // Min-heap to keep track of the end times of the groups
            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

            foreach (var interval in intervals)
            {
                int start = interval[0];
                int end = interval[1];

                // If the earliest ending group can accommodate the current interval
                if (minHeap.Count > 0 && minHeap.Peek() < start)
                {
                    minHeap.Dequeue();
                }

                // Add the current interval's end time to the heap
                minHeap.Enqueue(end, end);
            }

            // The size of the heap represents the minimum number of groups required
            return minHeap.Count;
        }
    }
}
