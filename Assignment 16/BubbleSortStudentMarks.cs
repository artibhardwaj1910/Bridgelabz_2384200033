using System;

namespace SortingAssignment
{
    class BubbleSortStudentMarks
    {
        static void Main()
        {
            // Declare the array to store student marks
            int[] studentMarks;

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
            studentMarks = new int[numberOfStudents];

            // Get student marks from user
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"Enter marks for student {i + 1}: ");
                studentMarks[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Perform Bubble Sort
            for (int i = 0; i < studentMarks.Length - 1; i++)
            {
                bool swapped = false; // Track if a swap occurred
                for (int j = 0; j < studentMarks.Length - 1 - i; j++)
                {
                    if (studentMarks[j] > studentMarks[j + 1])
                    {
                        // Swap the elements
                        int temp = studentMarks[j];
                        studentMarks[j] = studentMarks[j + 1];
                        studentMarks[j + 1] = temp;
                        swapped = true;
                    }
                }
                // If no swaps occurred, the array is already sorted
                if (!swapped)
                    break;
            }

            // Display sorted marks
            Console.WriteLine("\nSorted Marks in Ascending Order:");
            for (int i = 0; i < studentMarks.Length; i++)
            {
                Console.Write(studentMarks[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
