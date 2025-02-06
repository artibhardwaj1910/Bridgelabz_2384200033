using System;
namespace StringAssignment
{
    class MostFrequentCharacter
    {
        static void Main()
        {
            // Get user input
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int length = 0;

            // Find string length
            while (length < input.Length)
                length++;

            // Count frequency of each character
            int[] frequency = new int[256];
            int i = 0;
            while (i < length)
            {
                frequency[input[i]]++;
                i++;
            }

            // Find the most frequent character
            int maxCount = 0;
            char mostFrequent = '\0';
            i = 0;
            while (i < length)
            {
                if (frequency[input[i]] > maxCount)
                {
                    maxCount = frequency[input[i]];
                    mostFrequent = input[i];
                }
                i++;
            }

            // Display result
            Console.WriteLine("Most Frequent Character: '" + mostFrequent + "'");
        }
    }
}

