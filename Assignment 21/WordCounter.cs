using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class WordCounter
{
    static void Main()
    {
        string filePath = "textfile.txt"; // Update with actual file path
        try
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = Regex.Split(line.ToLower(), "\W+");
                    foreach (string word in words)
                    {
                        if (!string.IsNullOrWhiteSpace(word))
                        {
                            if (wordCount.ContainsKey(word))
                                wordCount[word]++;
                            else
                                wordCount[word] = 1;
                        }
                    }
                }
            }

            var topWords = wordCount.OrderByDescending(kv => kv.Value).Take(5);
            Console.WriteLine("Top 5 most frequent words:");
            foreach (var kv in topWords)
            {
                Console.WriteLine($"{kv.Key}: {kv.Value}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}