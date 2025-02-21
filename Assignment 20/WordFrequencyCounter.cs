using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
namespace CollectionsAssignment
{
    class WordFrequencyCounter
    {
        // Method to count word frequency from a file
        static Dictionary<string, int> CountWordFrequency(string filePath)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            // Read file content
            string text = File.ReadAllText(filePath);

            // Convert to lowercase and remove punctuation
            text = Regex.Replace(text.ToLower(), @"[^\w\s]", "");

            // Split into words
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // Count frequency of each word
            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            return wordCount;
        }

        static void Main()
        {
            // File path (Ensure this file exists in the same directory)
            string filePath = "sample.txt";

            // Check if file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: File not found!");
                return;
            }

            // Get word frequency
            Dictionary<string, int> wordFrequency = CountWordFrequency(filePath);

            // Display word frequencies
            Console.WriteLine("Word Frequencies:");
            foreach (var pair in wordFrequency)
            {
                Console.WriteLine($"'{pair.Key}': {pair.Value}");
            }
        }
    }
}

