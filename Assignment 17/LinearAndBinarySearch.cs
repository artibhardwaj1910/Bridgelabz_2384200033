using System;
namespace SearchAssignment
{
    class LinearAndBinarySearch
    {
        static void Main()
        {
            // Declare an array of integers
            int[] numbers = { 3, 4, -1, 1, 6, 2, 8, 5 };

            // Find the first missing positive integer using Linear Search
            int missingNumber = FindFirstMissingPositive(numbers);
            Console.WriteLine($"First missing positive integer: {missingNumber}");

            // Ask user for target value
            Console.Write("Enter the target number to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            // Sort the array for Binary Search
            Array.Sort(numbers);

            // Perform Binary Search to find the target index
            int targetIndex = BinarySearch(numbers, target);

            // Display result
            if (targetIndex != -1)
            {
                Console.WriteLine($"Target {target} found at index {targetIndex}");
            }
            else
            {
                Console.WriteLine($"Target {target} not found in the array.");
            }
        }

        // Method to find the first missing positive integer using Linear Search
        static int FindFirstMissingPositive(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i])
                {
                    // Swap arr[i] to its correct position
                    int temp = arr[i];
                    arr[i] = arr[temp - 1];
                    arr[temp - 1] = temp;
                }
            }

            // Find the first missing positive number
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != i + 1)
                {
                    return i + 1;
                }
            }
            return n + 1;
        }

        // Method to perform Binary Search
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                {
                    return mid; // Target found
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1; // Search in right half
                }
                else
                {
                    right = mid - 1; // Search in left half
                }
            }
            return -1; // Target not found
        }
    }
}

