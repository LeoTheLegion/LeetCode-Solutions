using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public string LongestDiverseString(int a, int b, int c)
        {
            var sb = new StringBuilder();
            var pq = new PriorityQueue<(int count, char ch), int>(Comparer<int>.Create((x, y) => y - x));

            // Add the characters to the priority queue
            if (a > 0)
                pq.Enqueue((a, 'a'), a);
            if (b > 0)
                pq.Enqueue((b, 'b'), b);
            if (c > 0)
                pq.Enqueue((c, 'c'), c);

            while (pq.Count > 0)
            {
                var (count1, ch1) = pq.Dequeue();

                // If the last two characters are the same as the current character
                if (sb.Length >= 2 && sb[sb.Length - 1] == ch1 && sb[sb.Length - 2] == ch1)
                {
                    if (pq.Count == 0)
                        break;

                    /// Get the next character
                    var (count2, ch2) = pq.Dequeue();
                    sb.Append(ch2);
                    // If the count of the next character is greater than 1
                    if (count2 > 1)
                        // Add the character back to the priority queue
                        pq.Enqueue((count2 - 1, ch2), count2 - 1);
                    // Add the current character back to the priority queue
                    pq.Enqueue((count1, ch1), count1);
                }
                else
                {
                    // Add the current character to the string
                    sb.Append(ch1);
                    // If the count of the current character is greater than 1
                    if (count1 > 1)
                        // Add the character back to the priority queue
                        pq.Enqueue((count1 - 1, ch1), count1 - 1);
                }
            }

            return sb.ToString();
        }
    }
}
