using System;

namespace SortingAssignment
{
    class CountingSortStudentAges
    {
        static void Main()
        {
            // Declare the array to store student ages
            int[] studentAges;

            // Get the number of students
            Console.Write("Enter the number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            // Validate input
            if (numberOfStudents <= 0)
            {
                Console.WriteLine("Invalid number of students. Exiting program.");
                return;
            }

            // Initialize the array
            studentAges = new int[numberOfStudents];

            // Get student ages from user
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"Enter age of student {i + 1} (between 10 and 18): ");
                studentAges[i] = Convert.ToInt32(Console.ReadLine());

                // Validate age range
                if (studentAges[i] < 10 || studentAges[i] > 18)
                {
                    Console.WriteLine("Invalid age. Please enter a value between 10 and 18.");
                    return;
                }
            }

            // Perform Counting Sort
            studentAges = CountingSort(studentAges, 10, 18);

            // Display sorted student ages
            Console.WriteLine("\nSorted Student Ages in Ascending Order:");
            for (int i = 0; i < studentAges.Length; i++)
            {
                Console.Write(studentAges[i] + " ");
            }
            Console.WriteLine();
        }

        // Counting Sort function
        static int[] CountingSort(int[] arr, int min, int max)
        {
            int range = max - min + 1;
            int[] countArray = new int[range]; // Count array
            int[] outputArray = new int[arr.Length]; // Output array

            // Count occurrences of each age
            for (int i = 0; i < arr.Length; i++)
            {
                countArray[arr[i] - min]++;
            }

            // Compute cumulative count
            for (int i = 1; i < range; i++)
            {
                countArray[i] += countArray[i - 1];
            }

            // Place elements in sorted order
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                outputArray[countArray[arr[i] - min] - 1] = arr[i];
                countArray[arr[i] - min]--;
            }

            return outputArray;
        }
    }
}
