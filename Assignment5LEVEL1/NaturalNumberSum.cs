using System;
namespace Assignment05Level1
{
    class NaturalNumberSum
    {
        // Method to calculate the sum of natural numbers

        static int CalculateSumOfNaturalNumbers(int n)
        {
            int sum = 0;

            // Loop from 1 to n and calculate the sum
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }

        // Main method

        public static void Main(string[] args)
        {
            // Get the value of n
            Console.Write("Enter a positive integer (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Calculate the sum of n natural numbers
            int sum = CalculateSumOfNaturalNumbers(n);

            // Output the result
            Console.WriteLine($"The sum of the first {n} natural numbers is {sum}.");
        }
    }
}