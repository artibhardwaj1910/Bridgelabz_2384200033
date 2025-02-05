using System;
namespace Assignment05Level2
{
    public class FriendComparison
    {
        // Method to find the youngest friend
        public static string FindYoungest(int[] ages, string[] names)
        {
            int minAge = ages[0];
            string youngestFriend = names[0];

            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < minAge)
                {
                    minAge = ages[i];
                    youngestFriend = names[i];
                }
            }

            return youngestFriend;
        }

        // Method to find the tallest friend
        public static string FindTallest(double[] heights, string[] names)
        {
            double maxHeight = heights[0];
            string tallestFriend = names[0];

            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > maxHeight)
                {
                    maxHeight = heights[i];
                    tallestFriend = names[i];
                }
            }

            return tallestFriend;
        }

        static void Main(string[] args)
        {
            // Arrays to store the ages and heights of friends
            int[] ages = new int[3];
            double[] heights = new double[3];
            string[] names = { "Amar", "Akbar", "Anthony" };

            // Taking input for the ages and heights of the friends
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter age for {names[i]}: ");
                ages[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Enter height for {names[i]} (in meters): ");
                heights[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Finding the youngest and tallest friends
            string youngestFriend = FindYoungest(ages, names);
            string tallestFriend = FindTallest(heights, names);

            // Displaying the results
            Console.WriteLine($"\nThe youngest friend is {youngestFriend}.");
            Console.WriteLine($"The tallest friend is {tallestFriend}.");
        }
    }
}

