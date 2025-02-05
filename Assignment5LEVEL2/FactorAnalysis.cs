using System;
namespace Assignment05Level2
{
    class FactorAnalysis
    {

        // Finds and returns all factors of a given number in an array.
        static int[] FindFactors(int number)
        {
            // Count the number of factors
            int factorCount = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factorCount++;
                }
            }

            // Store factors in an array
            int[] factors = new int[factorCount];
            int index = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }

            return factors;
        }

        /// Calculates and returns the sum of the factors.
        static int CalculateSumOfFactors(int[] factors)
        {
            int sum = 0;
            foreach (int factor in factors)
            {
                sum += factor;
            }
            return sum;
        }

        /// Calculates and returns the product of the factors.
        static int CalculateProductOfFactors(int[] factors)
        {
            int product = 1;
            foreach (int factor in factors)
            {
                product *= factor;
            }
            return product;
        }

        /// Calculates and returns the sum of squares of the factors.

        static double CalculateSumOfSquareOfFactors(int[] factors)
        {
            double sumOfSquares = 0;
            foreach (int factor in factors)
            {
                sumOfSquares += Math.Pow(factor, 2);
            }
            return sumOfSquares;
        }


       // Main Method
        static void Main(string[] args)
        {
            // input a number
            Console.WriteLine("Enter a positive integer:");
            int userInput;
            if (!int.TryParse(Console.ReadLine(), out userInput) || userInput <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            // Find the factors of the number
            int[] factors = FindFactors(userInput);

            // Display the factors
            Console.WriteLine("Factors of " + userInput + ": " + string.Join(", ", factors));

            // Calculate and display the sum of the factors
            int sumOfFactors = CalculateSumOfFactors(factors);
            Console.WriteLine("Sum of factors: " + sumOfFactors);

            // Calculate and display the product of the factors
            int productOfFactors = CalculateProductOfFactors(factors);
            Console.WriteLine("Product of factors: " + productOfFactors);

            // Calculate and display the sum of squares of the factors
            double sumOfSquareOfFactors = CalculateSumOfSquareOfFactors(factors);
            Console.WriteLine("Sum of squares of factors: " + sumOfSquareOfFactors);
        }
    }
}