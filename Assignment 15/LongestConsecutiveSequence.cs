using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    static void Main()
    {
        // Input array
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[size];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Finding the longest consecutive sequence length
        int longestLength = FindLongestConsecutiveSequence(numbers);
        Console.WriteLine($"Length of the longest consecutive sequence: {longestLength}");
    }

    static int FindLongestConsecutiveSequence(int[] nums)
    {
        HashSet<int> numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in nums)
        {
            // Check if it's the start of a sequence
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                // Count the length of consecutive sequence
                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }
}

