using System;
using System.IO;

namespace FileHandlingAssignment
{
    class CountWordOccurrences
    {
        static void Main()
        {
            // Specify the file path
            string filePath = "C:\Users\Ankit Singh\OneDrive\Desktop";

            // Ask the user for the word to search
            Console.Write("Enter the word to count: ");
            string searchWord = Console.ReadLine();
            
            int wordCount = 0; // Variable to store the count

            // Open the file and read it line by line
            StreamReader reader = new StreamReader(filePath);
            
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Splitting the line into words using space as delimiter
                string[] words = line.Split(' ');

                // Checking each word manually
                foreach (string word in words)
                {
                    if (word == searchWord) // Direct comparison
                    {
                        wordCount++; // Increase count if match found
                    }
                }
            }

            // Close the reader
            reader.Close();

            // Display the result
            Console.WriteLine($"The word '{searchWord}' appears {wordCount} times in the file.");
        }
    }
}

