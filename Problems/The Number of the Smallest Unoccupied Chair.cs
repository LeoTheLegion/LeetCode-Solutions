using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int SmallestChair(int[][] times, int targetFriend)
        {
            int n = times.Length;
            int[] target = times[targetFriend];
            Array.Sort(times, (a, b) => a[0] - b[0]);

            // Min-heap for available chairs
            PriorityQueue<int, int> availableChairs = new PriorityQueue<int, int>();
            for (int i = 0; i < n; i++)
            {
                availableChairs.Enqueue(i, i);
            }

            // Min-heap for occupied chairs with their end times
            PriorityQueue<(int endTime, int chair), int> occupiedChairs = new PriorityQueue<(int endTime, int chair), int>();

            for (int i = 0; i < n; i++)
            {
                int[] time = times[i];
                int start = time[0];
                int end = time[1];

                // Free up chairs that are now available
                while (occupiedChairs.Count > 0 && occupiedChairs.Peek().endTime <= start)
                {
                    var freedChair = occupiedChairs.Dequeue();
                    availableChairs.Enqueue(freedChair.chair, freedChair.chair);
                }

                // Allocate the smallest available chair
                int chair = availableChairs.Dequeue();
                if (time == target)
                {
                    return chair;
                }

                // Mark the chair as occupied until the end time
                occupiedChairs.Enqueue((end, chair), end);
            }

            return -1;
        }
    }
}
