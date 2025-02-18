using System;
namespace BinarySearchAssignment
{
    class FindPeakElement
    {
        static void Main()
        {
            // Declare an array
            int[] numbers = { 1, 3, 7, 8, 6, 2, 5 };

            // Perform Binary Search to find a peak element
            int peakIndex = FindPeak(numbers);

            // Display the result
            Console.WriteLine($"A peak element is {numbers[peakIndex]} at index {peakIndex}");
        }

        static int FindPeak(int[] arr)
        {
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                int mid = (left + right) / 2;

                // Compare mid with its next element
                if (arr[mid] < arr[mid + 1])
                {
                    left = mid + 1; // Move right if mid is smaller
                }
                else
                {
                    right = mid; // Move left if mid is greater
                }
            }

            // Left will be at a peak element
            return left;
        }
    }
}

