using System;

namespace Assignment05Level3
{
    public class FootballTeam
    {
        // Method to calculate the sum of all elements in the array
        public static int CalculateSum(int[] heights)
        {
            int sum = 0;
            foreach (int height in heights)
            {
                sum += height;
            }
            return sum;
        }

        // Method to calculate the mean height
        public static double CalculateMean(int[] heights)
        {
            int sum = CalculateSum(heights);
            return (double)sum / heights.Length;
        }

        // Method to find the shortest height
        public static int FindShortest(int[] heights)
        {
            int shortest = heights[0];
            foreach (int height in heights)
            {
                if (height < shortest)
                {
                    shortest = height;
                }
            }
            return shortest;
        }

        // Method to find the tallest height
        public static int FindTallest(int[] heights)
        {
            int tallest = heights[0];
            foreach (int height in heights)
            {
                if (height > tallest)
                {
                    tallest = height;
                }
            }
            return tallest;
        }

        static void Main(string[] args)
        {
            // Create an array for 11 players' heights
            int[] heights = new int[11];
            Random random = new Random();

            // Generate random heights for the players (150 to 250 cm)
            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = random.Next(150, 251);
            }

            // Display the players' heights
            Console.WriteLine("Heights of the football players (in cm):");
            foreach (int height in heights)
            {
                Console.Write(height + " ");
            }
            Console.WriteLine();

            // Calculate and display the results
            int sum = CalculateSum(heights);
            double mean = CalculateMean(heights);
            int shortest = FindShortest(heights);
            int tallest = FindTallest(heights);

            Console.WriteLine($"\nSum of heights: {sum} cm");
            Console.WriteLine($"Mean height: {mean:0.00} cm");
            Console.WriteLine($"Shortest player: {shortest} cm");
            Console.WriteLine($"Tallest player: {tallest} cm");
        }
    }
}

