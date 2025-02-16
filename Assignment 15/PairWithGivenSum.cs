using System;
using System.Collections.Generic;

class PairWithGivenSum
{
    static void Main()
    {
        // Input array and target sum
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[size];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter the target sum: ");
        int target = Convert.ToInt32(Console.ReadLine());

        // Checking for pair existence
        bool exists = HasPairWithSum(numbers, target);

        // Display result
        if (exists)
        {
            Console.WriteLine("Yes, a pair exists with the given sum.");
        }
        else
        {
            Console.WriteLine("No, no such pair exists.");
        }
    }

    static bool HasPairWithSum(int[] nums, int target)
    {
        HashSet<int> seenNumbers = new HashSet<int>();

        foreach (int num in nums)
        {
            int complement = target - num;

            // Check if complement is already in the set
            if (seenNumbers.Contains(complement))
            {
                return true;
            }

            // Add current number to the set
            seenNumbers.Add(num);
        }

        return false;
    }
}



