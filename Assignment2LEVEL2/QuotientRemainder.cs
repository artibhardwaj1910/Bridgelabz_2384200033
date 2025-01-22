using System;
namespace Program{
    class QuotientRemainder{
        static void Main(string[] args){
            // For user input
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Calculate quotient and remainder
            int quotient = number1 / number2;
            int remainder = number1 % number2;

            // Display the result
            Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}."); }}}