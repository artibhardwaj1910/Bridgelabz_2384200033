using System;
namespace BinarySearchAssignment
{
    class SearchInSortedMatrix
    {
        static void Main()
        {
            // Declare a 2D sorted matrix
            int[,] matrix = 
            {
                { 1, 3, 5, 7 },
                { 10, 11, 16, 20 },
                { 23, 30, 34, 60 }
            };

            // Ask the user for the target value
            Console.Write("Enter the target value to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            // Perform Binary Search in the 2D matrix
            bool found = SearchMatrix(matrix, target);

            // Display the result
            if (found)
            {
                Console.WriteLine("Target value found in the matrix.");
            }
            else
            {
                Console.WriteLine("Target value not found in the matrix.");
            }
        }

        static bool SearchMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int left = 0, right = rows * cols - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int midValue = matrix[mid / cols, mid % cols];

                if (midValue == target)
                {
                    return true;
                }
                else if (midValue < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return false;
        }
    }
}

