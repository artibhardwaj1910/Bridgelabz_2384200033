using System;
namespace StringAssignment
{
    class SubstringOccurrences
    {
        static void Main()
        {
            // Get user input
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter a substring to find: ");
            string sub = Console.ReadLine();

            int inputLength = 0, subLength = 0;

            // Find string lengths
            while (inputLength < input.Length)
                inputLength++;
            while (subLength < sub.Length)
                subLength++;

            // Count occurrences
            int count = 0, i = 0;
            while (i <= inputLength - subLength)
            {
                int j = 0;
                while (j < subLength && input[i + j] == sub[j])
                    j++;

                if (j == subLength)
                    count++;

                i++;
            }

            // Display result
            Console.WriteLine("Occurrences: " + count);
        }
    }
}

