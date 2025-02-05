using System;
namespace Assignment05Level1{
    class QuotientAndRemainderFinder{
        // Method to find the quotient and remainder of two numbers.
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int quotient = number / divisor; 
            int remainder = number % divisor;

            return new int[] { quotient, remainder };
        }

       // Main method
        public static void Main(string[] args)
        {
            // Get dividend from the user
            Console.Write("Enter the dividend (number): ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Get the divisor from the user
            Console.Write("Enter the divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            // Check if divisor is zero to prevent division by zero error
            if (divisor == 0)
            {
                Console.WriteLine("Divisor cannot be zero.");
                return;
            }

            // Find the quotient and remainder
            int[] results = FindRemainderAndQuotient(number, divisor);

            // Output the results
            Console.WriteLine($"The quotient is {results[0]} and the remainder is {results[1]}.");
        }
    }
}

