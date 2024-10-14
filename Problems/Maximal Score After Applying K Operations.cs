using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public long MaxKelements(int[] nums, int k)
        {
            // Use a max-heap to always pick the largest element
            PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

            // Add all elements to the max-heap
            foreach (int num in nums)
            {
                maxHeap.Enqueue(num, num);
            }

            long sum = 0;

            // Perform k operations
            for (int i = 0; i < k; i++)
            {
                // Get the largest element
                int largest = maxHeap.Dequeue();
                sum += largest;

                // Reduce the largest element and add it back to the heap
                int reduced = (int)Math.Ceiling(largest / 3.0);
                maxHeap.Enqueue(reduced, reduced);
            }

            return sum;
        }
    }
}
