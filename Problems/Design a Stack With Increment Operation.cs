using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class CustomStack
    {
        int[] data;
        int count;

        public CustomStack(int maxSize)
        {
            data = new int[maxSize];
            count = 0;
        }

        public void Push(int x)
        {
            // If the stack is not full
            if (count < data.Length)
            {
                // Add the element to the stack
                data[count] = x;
                count++;
            }
        }

        public int Pop()
        {
            // If the stack is not empty
            // Return the last element and decrement the count
            // else return -1
            return count > 0 ? data[--count] : -1;
        }

        public void Increment(int k, int val)
        {
            // Increment the first k elements by val
            for (int i = 0; i < k && i < count; i++)
            {
                // Increment the element
                data[i] += val;
            }
        }
    }

    /**
     * Your CustomStack object will be instantiated and called as such:
     * CustomStack obj = new CustomStack(maxSize);
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * obj.Increment(k,val);
     */
}
