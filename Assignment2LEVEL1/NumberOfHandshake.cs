using System;
namespace Program{
    class NumberOfHandshake{
        static void Main(string[] args){
            // Declare variable
            int numberOfStudents;

            // For user input
            Console.WriteLine("Enter the number of students:");
            numberOfStudents = Convert.ToInt32(Console.ReadLine());

            // Calculate the maximumHandshakes
            int maximumHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

            // Display the result
            Console.WriteLine($"The maximum number of possible handshakes among {numberOfStudents} students is: {maximumHandshakes}"); }}}