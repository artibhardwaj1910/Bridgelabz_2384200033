using System;

namespace SortingAssignment
{
    class SelectionSortExamScores
    {
        static void Main()
        {
            // Declare the array to store exam scores
            int[] examScores;

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
            examScores = new int[numberOfStudents];

            // Get exam scores from user
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"Enter exam score of student {i + 1}: ");
                examScores[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Perform Selection Sort
            for (int i = 0; i < examScores.Length - 1; i++)
            {
                int minIndex = i; // Assume the first unsorted element is the smallest

                // Find the minimum element in the remaining unsorted array
                for (int j = i + 1; j < examScores.Length; j++)
                {
                    if (examScores[j] < examScores[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the first element of the unsorted part
                int temp = examScores[minIndex];
                examScores[minIndex] = examScores[i];
                examScores[i] = temp;
            }

            // Display sorted exam scores
            Console.WriteLine("\nSorted Exam Scores in Ascending Order:");
            for (int i = 0; i < examScores.Length; i++)
            {
                Console.Write(examScores[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
