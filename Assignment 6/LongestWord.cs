using System;
namespace StringAssignment{
    class LongestWord{
        static void Main()
        {
            // Get user input
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();
            int length = 0;

            // Find string length
            while (length < input.Length)
                length++;

            // Find the longest word
            int maxLen = 0, wordLen = 0, startIndex = 0, maxStart = 0;
            int i = 0;
            while (i <= length)
            {
                if (i == length || input[i] == ' ')
                {
                    if (wordLen > maxLen)
                    {
                        maxLen = wordLen;
                        maxStart = startIndex;
                    }
                    wordLen = 0;
                    startIndex = i + 1;
                }
                else
                {
                    wordLen++;
                }
                i++;
            }

            // Display result
            Console.Write("Longest Word: ");
            i = 0;
            while (i < maxLen)
            {
                Console.Write(input[maxStart + i]);
                i++;
            }
            Console.WriteLine();
        }
    }
}

