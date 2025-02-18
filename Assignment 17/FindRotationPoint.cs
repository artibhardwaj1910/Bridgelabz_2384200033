using System;
namespace BinarySearchAssignment
{
    class FindRotationPoint
    {
        static void Main()
        {
            // Declare a rotated sorted array
            int[] numbers = { 7, 8, 9, 1, 2, 3, 4, 5, 6 };

            // Perform Binary Search to find the rotation point
            int rotationIndex = FindRotationIndex(numbers);

            // Display the result
            Console.WriteLine($"The index of the smallest element (rotation point) is: {rotationIndex}");
        }

        static int FindRotationIndex(int[] arr)
        {
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                int mid = (left + right) / 2;

                // If mid element is greater than the rightmost element, search in right half
                if (arr[mid] > arr[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid; // Search in left half including mid
                }
            }

            // Left will point to the smallest element
            return left;
        }
    }
}

