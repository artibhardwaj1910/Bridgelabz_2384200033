using System;

namespace StockSpanProblem
{
    class Stack
    {
        private int[] stackArray;
        private int top;
        private int capacity;

        public Stack(int size)
        {
            capacity = size;
            stackArray = new int[capacity];
            top = -1;
        }

        public void Push(int data)
        {
            if (top == capacity - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            stackArray[++top] = data;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return stackArray[top--];
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return stackArray[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }

    class StockSpan
    {
        public static void CalculateSpan(int[] prices, int[] spans)
        {
            int n = prices.Length;
            Stack stack = new Stack(n);
            stack.Push(0);
            spans[0] = 1;

            for (int i = 1; i < n; i++)
            {
                while (!stack.IsEmpty() && prices[stack.Peek()] <= prices[i])
                {
                    stack.Pop();
                }

                spans[i] = stack.IsEmpty() ? i + 1 : i - stack.Peek();
                stack.Push(i);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
            int[] spans = new int[prices.Length];

            StockSpan.CalculateSpan(prices, spans);

            Console.WriteLine("Stock Prices: " + string.Join(", ", prices));
            Console.WriteLine("Span Values:  " + string.Join(", ", spans));
        }
    }
}

