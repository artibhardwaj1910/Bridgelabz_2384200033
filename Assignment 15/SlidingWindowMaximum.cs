using System;
namespace SlidingWindowMaximum
{
    class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
    }

    class Deque
    {
        private Node front;
        private Node rear;

        public Deque()
        {
            front = rear = null;
        }

        public void PushBack(int data)
        {
            Node newNode = new Node(data);
            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.next = newNode;
                newNode.prev = rear;
                rear = newNode;
            }
        }

        public void PopFront()
        {
            if (front == null) return;
            front = front.next;
            if (front != null)
                front.prev = null;
            else
                rear = null;
        }

        public void PopBack()
        {
            if (rear == null) return;
            rear = rear.prev;
            if (rear != null)
                rear.next = null;
            else
                front = null;
        }

        public int Front()
        {
            return front != null ? front.data : -1;
        }

        public int Back()
        {
            return rear != null ? rear.data : -1;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }

    class SlidingWindow
    {
        public static int[] FindMaxInWindows(int[] arr, int k)
        {
            int n = arr.Length;
            if (n == 0 || k == 0) return new int[0];

            int[] result = new int[n - k + 1];
            Deque deque = new Deque();

            for (int i = 0; i < n; i++)
            {
                if (!deque.IsEmpty() && deque.Front() < i - k + 1)
                {
                    deque.PopFront();
                }

                while (!deque.IsEmpty() && arr[deque.Back()] <= arr[i])
                {
                    deque.PopBack();
                }

                deque.PushBack(i);

                if (i >= k - 1)
                {
                    result[i - k + 1] = arr[deque.Front()];
                }
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;

            int[] maxWindows = SlidingWindow.FindMaxInWindows(arr, k);

            Console.WriteLine("Sliding Window Maximums: " + string.Join(", ", maxWindows));
        }
    }
}

