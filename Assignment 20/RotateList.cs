using System;
using System.Collections.Generic;
namespace CollectionsAssignment
{
    class RotateList
    {
        // Method to rotate elements in a list by given positions
        static List<int> RotateElements(List<int> numbers, int positions)
        {
            int n = numbers.Count;
            List<int> rotatedList = new List<int>();

            // Ensure positions is within range
            positions = positions % n;

            // Add elements from the rotated index to the end
            for (int i = positions; i < n; i++)
            {
                rotatedList.Add(numbers[i]);
            }

            // Add the first part of the list
            for (int i = 0; i < positions; i++)
            {
                rotatedList.Add(numbers[i]);
            }

            return rotatedList;
        }

        static void Main()
        {
            // Input list
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            // Rotation positions
            int rotateBy = 2;

            // Rotate and display result
            List<int> rotatedNumbers = RotateElements(numbers, rotateBy);

            Console.WriteLine("Rotated List: " + string.Join(", ", rotatedNumbers));
        }
    }
}

