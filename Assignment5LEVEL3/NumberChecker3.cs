using System;

namespace Assignment05Level3
{
    public class NumberChecker3
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

        // Method to reverse the digits array
        public static int[] ReverseArray(int[] digits)
        {
            int[] reversedArray = new int[digits.Length];
            for (int i = 0; i < digits.Length; i++)
            {
                reversedArray[i] = digits[digits.Length - 1 - i];
            }
            return reversedArray;
        }

        // Method to compare two arrays and check if they are equal
        public static bool AreArraysEqual(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        // Method to check if a number is a palindrome using the digits
        public static bool IsPalindrome(int number)
        {
            int[] digits = GetDigitsArray(number);
            int[] reversedDigits = ReverseArray(digits);
            return AreArraysEqual(digits, reversedDigits);
        }

        // Method to check if a number is a duck number using the digits array
        public static bool IsDuckNumber(int number)
        {
            int[] digits = GetDigitsArray(number);
            foreach (int digit in digits)
            {
                if (digit == 0)
                {
                    return true; // Duck number has at least one zero
                }
            }
            return false; // No zero found, not a duck number
        }

        static void Main(string[] args)
        {
            // Take input from the user
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Get the digits array
            int[] digits = GetDigitsArray(number);

            // Reverse the digits array
            int[] reversedDigits = ReverseArray(digits);

            // Check if the number is a palindrome
            bool isPalindrome = IsPalindrome(number);

            // Check if the number is a duck number
            bool isDuckNumber = IsDuckNumber(number);

            // Display results
            Console.WriteLine($"\nNumber: {number}");
            Console.WriteLine("Digits: " + string.Join(", ", digits));
            Console.WriteLine("Reversed Digits: " + string.Join(", ", reversedDigits));
            Console.WriteLine($"Is Palindrome: {isPalindrome}");
            Console.WriteLine($"Is Duck Number: {isDuckNumber}");
        }
    }
}



