using System;
namespace BinarySearchAssignment
{
    class FirstAndLastOccurrence
    {
        static void Main()
        {
            // Declare a sorted array
            int[] numbers = { 1, 2, 2, 2, 3, 4, 5, 5, 5, 6 };

            // Ask the user for the target value
            Console.Write("Enter the target value: ");
            int target = Convert.ToInt32(Console.ReadLine());

            // Perform Binary Search to find the first and last occurrence
            int firstIndex = FindOccurrence(numbers, target, true);
            int lastIndex = FindOccurrence(numbers, target, false);

            // Display the result
            if (firstIndex != -1)
            {
                Console.WriteLine($"First occurrence at index: {firstIndex}");
                Console.WriteLine($"Last occurrence at index: {lastIndex}");
            }
            else
            {
                Console.WriteLine("Target value not found in the array.");
            }
        }

        static int FindOccurrence(int[] arr, int target, bool findFirst)
        {
            int left = 0, right = arr.Length - 1;
            int result = -1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                {
                    result = mid; // Store the index
                    if (findFirst)
                    {
                        right = mid - 1; // Search in left half for first occurrence
                    }
                    else
                    {
                        left = mid + 1; // Search in right half for last occurrence
                    }
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
    }
}

