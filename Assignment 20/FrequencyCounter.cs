using System;
using System.Collections.Generic;
namespace CollectionsAssignment
{
    class FrequencyCounter
    {
        // Method to count the frequency of elements in a list
        static Dictionary<string, int> CountFrequency(List<string> items)
        {
            Dictionary<string, int> frequencyDict = new Dictionary<string, int>();

            foreach (string item in items)
            {
                if (frequencyDict.ContainsKey(item))
                {
                    frequencyDict[item]++; // Increment count if item already exists
                }
                else
                {
                    frequencyDict[item] = 1; // Add new item with count 1
                }
            }

            return frequencyDict;
        }

        static void Main()
        {
            // Input list of strings
            List<string> fruits = new List<string> { "apple", "banana", "apple", "orange" };

            // Get the frequency count
            Dictionary<string, int> result = CountFrequency(fruits);

            // Display the result
            Console.WriteLine("Element Frequency:");
            foreach (var item in result)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}

