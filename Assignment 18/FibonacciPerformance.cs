using System;
using System.Diagnostics;
namespace TimeNSpaceAssignment
{
    class FibonacciPerformance
    {
        // Recursive Fibonacci (O(2^N)) - Inefficient
        static int FibonacciRecursive(int n)
        {
            if (n <= 1) return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        // Iterative Fibonacci (O(N)) - Efficient
        static int FibonacciIterative(int n)
        {
            if (n <= 1) return n;
            
            int a = 0, b = 1, sum;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }

        static void Main()
        {
            int[] testCases = { 10, 30, 50 };

            foreach (int n in testCases)
            {
                Console.WriteLine($"Fibonacci Number: N={n}");

                // Recursive Fibonacci Timing (Inefficient)
                Stopwatch stopwatch = Stopwatch.StartNew();
                if (n <= 40) // Limit due to exponential time complexity
                {
                    int resultRecursive = FibonacciRecursive(n);
                    stopwatch.Stop();
                    Console.WriteLine($"Recursive (O(2^N)) | N={n} | Time={stopwatch.ElapsedMilliseconds} ms | Result={resultRecursive}");
                }
                else
                {
                    Console.WriteLine($"Recursive (O(2^N)) | N={n} | Skipped (Too Slow)");
                }

                // Iterative Fibonacci Timing (Efficient)
                stopwatch.Restart();
                int resultIterative = FibonacciIterative(n);
                stopwatch.Stop();
                Console.WriteLine($"Iterative (O(N)) | N={n} | Time={stopwatch.ElapsedMilliseconds} ms | Result={resultIterative}\n");
            }
        }
    }
}
