using System;

namespace LeetCode.Problems
{
    public class MyCircularDeque
    {
        private int[] deque;
        private int front;
        private int rear;
        private int count;
        private int capacity;

        public MyCircularDeque(int k)
        {
            capacity = k;
            deque = new int[capacity];
            front = 0;
            rear = 0;
            count = 0;
        }

        public bool InsertFront(int value)
        {
            if (IsFull()) return false;
            
            front = (front - 1 + capacity) % capacity;
            deque[front] = value;
            count++;
            return true;
        }

        public bool InsertLast(int value)
        {
            if (IsFull()) return false;

            deque[rear] = value;
            rear = (rear + 1) % capacity;
            count++;
            return true;
        }

        public bool DeleteFront()
        {
            if (IsEmpty()) return false;

            front = (front + 1) % capacity;
            count--;
            return true;
        }

        public bool DeleteLast()
        {
            if (IsEmpty()) return false;

            rear = (rear - 1 + capacity) % capacity;
            count--;
            return true;
        }

        public int GetFront()
        {
            if (IsEmpty()) return -1;
            return deque[front];
        }

        public int GetRear()
        {
            if (IsEmpty()) return -1;
            return deque[(rear - 1 + capacity) % capacity];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == capacity;
        }
    }
}