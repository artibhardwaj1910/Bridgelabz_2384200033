using System;
using System.Collections.Generic;

class ZeroSumSubarrays
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

        // Find and display all zero-sum subarrays
        FindZeroSumSubarrays(numbers);
    }

    static void FindZeroSumSubarrays(int[] nums)
    {
        Dictionary<int, List<int>> sumIndices = new Dictionary<int, List<int>>();
        int cumulativeSum = 0;

        // Store initial sum occurrence
        sumIndices[0] = new List<int> { -1 };

        Console.WriteLine("Zero-sum subarrays:");

        for (int i = 0; i < nums.Length; i++)
        {
            cumulativeSum += nums[i];

            // If the sum has been seen before, it means there's a zero-sum subarray
            if (sumIndices.ContainsKey(cumulativeSum))
            {
                foreach (int startIndex in sumIndices[cumulativeSum])
                {
                    Console.WriteLine($"[{startIndex + 1}, {i}]");
                }
            }

            // Store index for current cumulative sum
            if (!sumIndices.ContainsKey(cumulativeSum))
            {
                sumIndices[cumulativeSum] = new List<int>();
            }
            sumIndices[cumulativeSum].Add(i);
        }
    }
}



