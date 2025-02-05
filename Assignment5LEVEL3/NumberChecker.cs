using System;

namespace Assignment05Level3
{
    public class NumberChecker
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

        // Method to check if a number is a duck number
        public static bool IsDuckNumber(int[] digits)
        {
            for (int i = 1; i < digits.Length; i++) // Skip the first digit
            {
                if (digits[i] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        // Method to check if a number is an Armstrong number
        public static bool IsArmstrongNumber(int[] digits)
        {
            int power = digits.Length;
            int sum = 0;

            foreach (int digit in digits)
            {
                sum += (int)Math.Pow(digit, power);
            }

            int originalNumber = 0;
            foreach (int digit in digits)
            {
                originalNumber = originalNumber * 10 + digit;
            }

            return sum == originalNumber;
        }

        // Method to find the largest and second largest digits
        public static (int largest, int secondLargest) FindLargestAndSecondLargest(int[] digits)
        {
            int largest = Int32.MinValue;
            int secondLargest = Int32.MinValue;

            foreach (int digit in digits)
            {
                if (digit > largest)
                {
                    secondLargest = largest;
                    largest = digit;
                }
                else if (digit > secondLargest && digit < largest)
                {
                    secondLargest = digit;
                }
            }

            return (largest, secondLargest);
        }

        // Method to find the smallest and second smallest digits
        public static (int smallest, int secondSmallest) FindSmallestAndSecondSmallest(int[] digits)
        {
            int smallest = Int32.MaxValue;
            int secondSmallest = Int32.MaxValue;

            foreach (int digit in digits)
            {
                if (digit < smallest)
                {
                    secondSmallest = smallest;
                    smallest = digit;
                }
                else if (digit < secondSmallest && digit > smallest)
                {
                    secondSmallest = digit;
                }
            }

            return (smallest, secondSmallest);
        }

        static void Main(string[] args)
        {
            // Input a number from the user
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Get the digits array
            int[] digits = GetDigitsArray(number);

            // Display results
            Console.WriteLine($"\nNumber: {number}");
            Console.WriteLine($"Count of digits: {CountDigits(number)}");
            Console.WriteLine("Digits: " + string.Join(", ", digits));
            Console.WriteLine($"Is Duck Number: {IsDuckNumber(digits)}");
            Console.WriteLine($"Is Armstrong Number: {IsArmstrongNumber(digits)}");

            var (largest, secondLargest) = FindLargestAndSecondLargest(digits);
            Console.WriteLine($"Largest digit: {largest}");
            Console.WriteLine($"Second largest digit: {secondLargest}");

            var (smallest, secondSmallest) = FindSmallestAndSecondSmallest(digits);
            Console.WriteLine($"Smallest digit: {smallest}");
            Console.WriteLine($"Second smallest digit: {secondSmallest}");
        }
    }
}

