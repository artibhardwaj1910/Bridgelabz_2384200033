using System;
namespace StringAssignment{
    class RemoveDuplicates{
        static void Main()
        {
            // Get user input
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int length = 0;

            // Find string length
            while (length < input.Length)
                length++;

            // Remove duplicates manually
            char[] result = new char[length];
            int resIndex = 0;
            int i = 0;
            while (i < length)
            {
                char current = input[i];
                bool found = false;

                // Check if the character is already added
                int j = 0;
                while (j < resIndex)
                {
                    if (result[j] == current)
                    {
                        found = true;
                        break;
                    }
                    j++;
                }

                if (!found)
                {
                    result[resIndex] = current;
                    resIndex++;
                }
                i++;
            }

            // Display result
            Console.Write("Modified String: ");
            i = 0;
            while (i < resIndex)
            {
                Console.Write(result[i]);
                i++;
            }
            Console.WriteLine();
        }
    }
}

