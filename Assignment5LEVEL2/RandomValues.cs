using System;
namespace Assignment05Level2
{
    public class RandomValues
    {
        // Method to generate an array
        public static int[] Generate4DigitRandomArray(int size)
        {
            Random random = new Random();
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                // Generate a 4-digit random number
                numbers[i] = random.Next(1000, 10000);
            }

            return numbers;
        }

        // Method to find average, min, and max value of an array
        public static double[] FindAverageMinMax(int[] numbers)
        {
            int sum = 0;
            int min = numbers[0];
            int max = numbers[0];

            foreach (int num in numbers)
            {
                sum += num;
                min = Math.Min(min, num);
                max = Math.Max(max, num);
            }

            double average = (double)sum / numbers.Length;
            return new double[] { average, min, max };
        }

        static void Main(string[] args)
        {
            // Generate 5 random 4-digit numbers
            int[] randomNumbers = Generate4DigitRandomArray(5);

            // Find average, min, and max of the generated numbers
            double[] results = FindAverageMinMax(randomNumbers);

            // Display the results
            Console.WriteLine("Generated 4-digit random numbers: ");
            foreach (int num in randomNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine($"Average value: {results[0]:0.00}");
            Console.WriteLine($"Minimum value: {results[1]}");
            Console.WriteLine($"Maximum value: {results[2]}");
        }
    }
}

