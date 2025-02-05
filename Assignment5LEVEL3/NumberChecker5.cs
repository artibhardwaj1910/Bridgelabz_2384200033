using System;

namespace Assignment05Level3
{
    public class NumberChecker5
    {
        // Method to find factors of a number
        public static int[] GetFactors(int number)
        {
            int factorCount = 0;

            // Count the number of factors
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factorCount++;
                }
            }

            int[] factors = new int[factorCount];
            int index = 0;

            // Store factors in the array
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index++] = i;
                }
            }

            return factors;
        }

        // Method to find the greatest factor of a number
        public static int FindGreatestFactor(int number)
        {
            int[] factors = GetFactors(number);
            return factors[^1]; // Last element in the factors array
        }

        // Method to find the sum of factors
        public static int FindSumOfFactors(int[] factors)
        {
            int sum = 0;
            foreach (int factor in factors)
            {
                sum += factor;
            }
            return sum;
        }

        // Method to find the product of factors
        public static long FindProductOfFactors(int[] factors)
        {
            long product = 1;
            foreach (int factor in factors)
            {
                product *= factor;
            }
            return product;
        }

        // Method to find the product of the cube of factors
        public static long FindProductOfCubeOfFactors(int[] factors)
        {
            long product = 1;
            foreach (int factor in factors)
            {
                product *= (long)Math.Pow(factor, 3);
            }
            return product;
        }

        // Method to check if a number is a perfect number
        public static bool IsPerfectNumber(int number)
        {
            int[] factors = GetFactors(number);
            int sumOfProperDivisors = FindSumOfFactors(factors) - number;
            return sumOfProperDivisors == number;
        }

        // Method to check if a number is an abundant number
        public static bool IsAbundantNumber(int number)
        {
            int[] factors = GetFactors(number);
            int sumOfProperDivisors = FindSumOfFactors(factors) - number;
            return sumOfProperDivisors > number;
        }

        // Method to check if a number is a deficient number
        public static bool IsDeficientNumber(int number)
        {
            int[] factors = GetFactors(number);
            int sumOfProperDivisors = FindSumOfFactors(factors) - number;
            return sumOfProperDivisors < number;
        }

        // Method to check if a number is a strong number
        public static bool IsStrongNumber(int number)
        {
            int sumOfFactorials = 0;
            int temp = number;

            while (temp > 0)
            {
                int digit = temp % 10;
                sumOfFactorials += Factorial(digit);
                temp /= 10;
            }

            return sumOfFactorials == number;
        }

        // Helper method to calculate factorial of a number
        private static int Factorial(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static void Main(string[] args)
        {
            // Take user input
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Perform operations
            int[] factors = GetFactors(number);
            int greatestFactor = FindGreatestFactor(number);
            int sumOfFactors = FindSumOfFactors(factors);
            long productOfFactors = FindProductOfFactors(factors);
            long productOfCubeOfFactors = FindProductOfCubeOfFactors(factors);
            bool isPerfect = IsPerfectNumber(number);
            bool isAbundant = IsAbundantNumber(number);
            bool isDeficient = IsDeficientNumber(number);
            bool isStrong = IsStrongNumber(number);

            // Display results
            Console.WriteLine($"\nFactors of {number}: {string.Join(", ", factors)}");
            Console.WriteLine($"Greatest Factor: {greatestFactor}");
            Console.WriteLine($"Sum of Factors: {sumOfFactors}");
            Console.WriteLine($"Product of Factors: {productOfFactors}");
            Console.WriteLine($"Product of Cube of Factors: {productOfCubeOfFactors}");
            Console.WriteLine($"Is Perfect Number: {isPerfect}");
            Console.WriteLine($"Is Abundant Number: {isAbundant}");
            Console.WriteLine($"Is Deficient Number: {isDeficient}");
            Console.WriteLine($"Is Strong Number: {isStrong}");
        }
    }
}

