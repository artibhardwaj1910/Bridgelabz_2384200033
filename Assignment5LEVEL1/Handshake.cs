using System;
namespace Assignment05Level1
{      
       class Handshake{

// Method to calculate the maximum number of handshakes.

        static int CalculateHandshakes(int students)
        {
            return (students * (students - 1)) / 2;
        }

// main method
        public static void Main(string[] args)
        {
            //Number of students
            Console.Write("Enter the number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            // Calculate maximum handshakes
            int maxHandshakes = CalculateHandshakes(numberOfStudents);

            // Output the result
            Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {maxHandshakes}.");
        }
    }
}