using System;
namespace Assignment05Level2
{
    class NaturalNumberSum
    {

        // Calculates sum of n natural numbers using recursion.
         static int CalculateSumRecursively(int n)
        {
            if (n == 1)
                return 1;             
             return n + CalculateSumRecursively(n - 1);        
         }

        /// Calculates sum of n natural numbers using formula
        static int CalculateSumUsingFormula(int n)
        {
            return n * (n + 1) / 2;
        }

//Main Method
        static void Main(string[] args)
        {
            // Prompt user to input a number
            Console.WriteLine("Enter a positive integer (natural number):");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Validate the input
            if (userInput <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            // Calculate the sum using recursion
            int recursiveSum = CalculateSumRecursively(userInput);

            // Calculate the sum using the formula
            int formulaSum = CalculateSumUsingFormula(userInput);

            // Display the results
            Console.WriteLine("Sum using recursion: " + recursiveSum);
            Console.WriteLine("Sum using formula: " + formulaSum);

            // Compare and display whether the results match
            if (recursiveSum == formulaSum)
            {
                Console.WriteLine("The results from recursion and the formula match.");
            }
            else
            {
                Console.WriteLine("The results from recursion and the formula do not match.");
            }
        }
    }
}

