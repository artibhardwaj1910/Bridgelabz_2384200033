using System;

namespace Assignment05Level3
{
    public class NumberChecker2
    {
        // Method to find the count of digits in a number
        public static int CountDigits(int number)
        {
            int count = 0;
            int temp = number;

            while (temp != 0)
            {
                count++;
                temp /= 10;
            }

            return count;
        }

        // Method to store digits of the number in a digits array
        public static int[] GetDigitsArray(int number)
        {
            int count = CountDigits(number);
            int[] digits = new int[count];
            int index = count - 1;

            while (number != 0)
            {
                digits[index--] = number % 10;
                number /= 10;
            }

            return digits;
        }

        // Method to find the sum of the digits of a number
        public static int SumOfDigits(int[] digits)
        {
            int sum = 0;
            foreach (int digit in digits)
            {
                sum += digit;
            }
            return sum;
        }

        // Method to find the sum of squares of the digits
        public static int SumOfSquares(int[] digits)
        {
            int sum = 0;
            foreach (int digit in digits)
            {
                sum += (int)Math.Pow(digit, 2);
            }
            return sum;
        }

        // Method to check if a number is a Harshad number
        public static bool IsHarshadNumber(int number, int[] digits)
        {
            int sum = SumOfDigits(digits);
            return number % sum == 0;
        }

        // Method to find the frequency of each digit
        public static int[,] FindDigitFrequency(int[] digits)
        {
            int[,] frequency = new int[10, 2]; // [digit, frequency]

            for (int i = 0; i < 10; i++)
            {
                frequency[i, 0] = i; // Initialize digit column
            }

            foreach (int digit in digits)
            {
                frequency[digit, 1]++; // Increment frequency for the digit
            }

            return frequency;
        }

        static void Main(string[] args)
        {
            // Input a number from the user
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Get the digits array
            int[] digits = GetDigitsArray(number);

            // Calculate results
            int count = CountDigits(number);
            int sum = SumOfDigits(digits);
            int sumOfSquares = SumOfSquares(digits);
            bool isHarshad = IsHarshadNumber(number, digits);
            int[,] frequency = FindDigitFrequency(digits);

            // Display results
            Console.WriteLine($"\nNumber: {number}");
            Console.WriteLine($"Count of digits: {count}");
            Console.WriteLine("Digits: " + string.Join(", ", digits));
            Console.WriteLine($"Sum of digits: {sum}");
            Console.WriteLine($"Sum of squares of digits: {sumOfSquares}");
            Console.WriteLine($"Is Harshad Number: {isHarshad}");

            Console.WriteLine("\nFrequency of digits:");
            for (int i = 0; i < 10; i++)
            {
                if (frequency[i, 1] > 0)
                {
                    Console.WriteLine($"Digit {frequency[i, 0]}: {frequency[i, 1]} times");
                }
            }
        }
    }
}

