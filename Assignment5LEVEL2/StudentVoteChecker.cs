using System;
namespace Assignment05Level2
{
    public class StudentVoteChecker
    {
        // Method to check if a student can vote
        public static bool CanStudentVote(int age)
        {
            // Validate the age and check if it is 18 or above
            if (age >= 18)
            {
                return true; // Can vote
            }
            else if (age < 0)
            {
                return false; // Invalid age
            }
            else
            {
                return false; // Cannot vote
            }
        }

        static void Main(string[] args)
        {
            // Array to store the age of 10 students
            int[] studentAges = new int[10];

            // Loop to take user input for student ages
            for (int i = 0; i < studentAges.Length; i++)
            {
                Console.Write($"Enter age for student {i + 1}: ");
                int age = Convert.ToInt32(Console.ReadLine());

                // Check if the student can vote
                if (CanStudentVote(age))
                {
                    Console.WriteLine("This student can vote.");
                }
                else
                {
                    Console.WriteLine("This student cannot vote.");
                }
            }
        }
    }
}

