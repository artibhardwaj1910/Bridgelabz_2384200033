using System;
using System.Text;

namespace StringBuilderAssignment
{
    class RemoveDuplicates
    {
        static void Main()
        {
            // Taking user input
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            // Using StringBuilder to store unique characters
            StringBuilder uniqueString = new StringBuilder();
            
            // Using an integer array to track character occurrence
            int[] charCount = new int[256];

            // Looping through the string using foreach to remove duplicates
            foreach (char currentChar in inputString)
            {
                // If character appears for the first time, add it
                if (charCount[currentChar] == 0)
                {
                    uniqueString.Append(currentChar);
                }

                // Increment character count
                charCount[currentChar]++;
            }

            // Displaying the string after removing duplicates
            Console.WriteLine("String after removing duplicates: " + uniqueString.ToString());
        }
    }
}

