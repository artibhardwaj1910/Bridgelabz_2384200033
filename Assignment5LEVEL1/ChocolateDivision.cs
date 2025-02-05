using System;
namespace Assignment05Level1
{
    class ChocolateDivision
    {

        // Method to find the quotient and remainder for dividing chocolates.
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int quotient = number / divisor;  // Chocolates each child gets
            int remainder = number % divisor; // Remaining chocolates

            return new int[] { quotient, remainder };
        }

        //Main Method
        public static void Main(string[] args)
        {
            // Get the total number of chocolates
            Console.Write("Enter the total number of chocolates: ");
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

            // Get the number of children
            Console.Write("Enter the number of children: ");
            int numberOfChildren = Convert.ToInt32(Console.ReadLine());

            // Calculate chocolates per child and remaining chocolates
            int[] results = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

            // Output the results
            Console.WriteLine($"Each child will get {results[0]} chocolates.");
            Console.WriteLine($"Remaining chocolates: {results[1]}.");
        }
    }
}