using System;
namespace Assignment05Level2
{
    public class NumberComparison
    {
        // Method to check whether the number is positive or negative
        public static string IsPositive(int number)
        {
            if (number >= 0)
            {
                return "positive";
            }
            else
            {
                return "negative";
            }
        }

        // Method to check whether the number is even or odd
        public static string IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }

        // Method to compare two numbers
        public static int Compare(int number1, int number2)
        {
            if (number1 > number2)
            {
                return 1; 
            }
            else if (number1 == number2)
            {
                return 0;
            }
            else
            {
                return -1; 
            }
        }

        static void Main(string[] args)
        {
            // Array to store 5 numbers
            int[] numbers = new int[5];

            // Take user input for 5 numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Loop through the array and check each number
            for (int i = 0; i < numbers.Length; i++)
            {
                string positivity = IsPositive(numbers[i]);
                string evenOdd = "N/A";

                if (positivity == "positive")
                {
                    evenOdd = IsEven(numbers[i]);
                    Console.WriteLine($"Number {numbers[i]} is {positivity} and {evenOdd}.");
                }
                else
                {
                    Console.WriteLine($"Number {numbers[i]} is {positivity}.");
                }
            }

            // Compare the first and last elements of the array
            int result = Compare(numbers[0], numbers[numbers.Length - 1]);

            if (result == 1)
            {
                Console.WriteLine($"The first number is greater than the last number.");
            }
            else if (result == 0)
            {
                Console.WriteLine($"The first number is equal to the last number.");
            }
            else
            {
                Console.WriteLine($"The first number is less than the last number.");
            }
        }
    }
}


