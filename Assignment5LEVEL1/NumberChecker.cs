using System;
namespace Assignment05Level1
{
    class NumberChecker
    {

    // Method to check whether a number is positive, negative, or zero.
        static int CheckNumberSign(int number)
        {
            if (number > 0)
            {
                return 1; // Positive
            }
            else if (number < 0)
            {
                return -1; // Negative
            }
            else
            {
                return 0; // Zero
            }
        }


       // main method
       public  static void Main(string[] args)
        {
            // Input: Get a number from the user
            Console.Write("Enter an integer: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Determine the nature of the number
            int result = CheckNumberSign(userInput);

            // Output the result
            if (result == 1)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (result == -1)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}

