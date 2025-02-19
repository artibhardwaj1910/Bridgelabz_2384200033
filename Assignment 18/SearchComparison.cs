using System;
using System.Diagnostics;
namespace TimeNSpaceAssignment
{
    class SearchComparison
    {
        // Generate random dataset
        static int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, size * 10);
            }
            return array;
        }

        // Linear Search (O(N))
        static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        // Binary Search (O(log N))
        static int BinarySearch(int[] array, int target)
        {
            int left = 0, right = array.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == target) return mid;
                else if (array[mid] < target) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }

        static void Main()
        {
            int[] sizes = { 1000, 10000, 1000000 };
            int target = -1; // Target unlikely to be in the dataset for worst-case performance

            foreach (int size in sizes)
            {
                int[] data = GenerateRandomArray(size);

                // Linear Search Timing
                Stopwatch stopwatch = Stopwatch.StartNew();
                LinearSearch(data, target);
                stopwatch.Stop();
                Console.WriteLine($"Linear Search | N={size} | Time={stopwatch.ElapsedMilliseconds} ms");

                // Binary Search Timing
                Array.Sort(data); // O(N log N) sorting cost
                stopwatch.Restart();
                BinarySearch(data, target);
                stopwatch.Stop();
                Console.WriteLine($"Binary Search | N={size} | Time={stopwatch.ElapsedMilliseconds} ms\n");
            }
        }
    }
}
