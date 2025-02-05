using System;
namespace Assignment05Level1{
    class SmallestAndLargestFinder{

       // Method to find the smallest and largest
                public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
        {
            int smallest = number1;
            int largest = number1;

            // Check for the smallest number
            if (number2 < smallest)
            {
                smallest = number2;
            }
            if (number3 < smallest)
            {
                smallest = number3;
            }

            // Check for the largest number
            if (number2 > largest)
            {
                largest = number2;
            }
            if (number3 > largest)
            {
                largest = number3;
            }

            return new int[] { smallest, largest };
        }

        // Main Method
        public static void Main(string[] args)
        {
            // Get three numbers from the user
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            // Find the smallest and largest numbers
            int[] results = FindSmallestAndLargest(number1, number2, number3);

            // Output the results
            Console.WriteLine($"The smallest number is {results[0]}.");
            Console.WriteLine($"The largest number is {results[1]}.");
        }
    }
}