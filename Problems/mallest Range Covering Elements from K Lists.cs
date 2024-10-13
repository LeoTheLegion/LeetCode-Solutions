using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public int[] SmallestRange(IList<IList<int>> nums)
        {
            // Min-heap to keep track of the smallest range
            PriorityQueue<(int value, int listIndex, int elementIndex), int> minHeap = new PriorityQueue<(int value, int listIndex, int elementIndex), int>();

            int max = int.MinValue;

            // Initialize the heap with the first element from each list
            for (int i = 0; i < nums.Count; i++)
            {
                minHeap.Enqueue((nums[i][0], i, 0), nums[i][0]);
                max = Math.Max(max, nums[i][0]);
            }

            int rangeStart = 0;
            int rangeEnd = int.MaxValue;

            while (minHeap.Count > 0)
            {
                var (value, listIndex, elementIndex) = minHeap.Dequeue();

                // Update the range if the current range is smaller
                if (max - value < rangeEnd - rangeStart)
                {
                    rangeStart = value;
                    rangeEnd = max;
                }

                // If the current list has more elements
                if (elementIndex + 1 < nums[listIndex].Count)
                {
                    int nextValue = nums[listIndex][elementIndex + 1];
                    minHeap.Enqueue((nextValue, listIndex, elementIndex + 1), nextValue);
                    max = Math.Max(max, nextValue);
                }
                else
                {
                    // If the current list has no more elements, break the loop
                    break;
                }
            }

            return new int[] { rangeStart, rangeEnd };
        }
    }
}
