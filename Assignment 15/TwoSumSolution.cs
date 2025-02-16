using System;
using System.Collections.Generic;

class TwoSumSolution
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

        // Finding the two indices
        int[] result = FindTwoSum(numbers, target);

        // Display result
        if (result.Length == 2)
        {
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        }
        else
        {
            Console.WriteLine("No two numbers found with the given sum.");
        }
    }

    static int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            // Check if complement exists in dictionary
            if (numIndices.ContainsKey(complement))
            {
                return new int[] { numIndices[complement], i };
            }

            // Store current number and its index
            numIndices[nums[i]] = i;
        }

        return new int[0]; // Return empty array if no solution
    }
}
