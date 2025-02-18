using System;
namespace LinearSearchAssignment
{
    class FirstNegativeNumberSearch
    {
        static void Main()
        {
            // Declare an integer array
            int[] numbers = { 10, 25, -3, 40, -7, 15 };

            // Variable to store the first negative number
            int firstNegative = 0; 

            // Perform Linear Search
            foreach (int num in numbers)
            {
                if (num < 0) // Check for negative number
                {
                    firstNegative = num;
                    break; // Stop after finding the first negative number
                }
            }

            // Display the result
            if (firstNegative < 0)
            {
                Console.WriteLine($"The first negative number in the array is: {firstNegative}");
            }
            else
            {
                Console.WriteLine("No negative number found in the array.");
            }
        }
    }
}

