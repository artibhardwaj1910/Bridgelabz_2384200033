using System;

namespace Assignment05Level3
{
    public class NumberChecker4
    {
        // Method to check if a number is a prime number
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        // Method to check if a number is a neon number
        public static bool IsNeonNumber(int number)
        {
            int square = number * number;
            int sumOfDigits = 0;

            while (square > 0)
            {
                sumOfDigits += square % 10;
                square /= 10;
            }

            return sumOfDigits == number;
        }

        // Method to check if a number is a spy number
        public static bool IsSpyNumber(int number)
        {
            int sum = 0, product = 1;

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                product *= digit;
                number /= 10;
            }

            return sum == product;
        }

        // Method to check if a number is an automorphic number
        public static bool IsAutomorphicNumber(int number)
        {
            int square = number * number;
            return square.ToString().EndsWith(number.ToString());
        }

        // Method to check if a number is a buzz number
        public static bool IsBuzzNumber(int number)
        {
            return number % 7 == 0 || number % 10 == 7;
        }

        static void Main(string[] args)
        {
            // Take input from the user
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Perform checks
            bool isPrime = IsPrime(number);
            bool isNeon = IsNeonNumber(number);
            bool isSpy = IsSpyNumber(number);
            bool isAutomorphic = IsAutomorphicNumber(number);
            bool isBuzz = IsBuzzNumber(number);

            // Display results
            Console.WriteLine($"\nResults for number: {number}");
            Console.WriteLine($"Is Prime Number: {isPrime}");
            Console.WriteLine($"Is Neon Number: {isNeon}");
            Console.WriteLine($"Is Spy Number: {isSpy}");
            Console.WriteLine($"Is Automorphic Number: {isAutomorphic}");
            Console.WriteLine($"Is Buzz Number: {isBuzz}");
        }
    }
}

