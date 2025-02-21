using System;
using System.Collections.Generic;
namespace CollectionsAssignment
{
    class InvertDictionary
    {
        // Method to invert a dictionary
        static Dictionary<int, List<string>> InvertMap(Dictionary<string, int> originalMap)
        {
            Dictionary<int, List<string>> invertedMap = new Dictionary<int, List<string>>();

            // Iterate over the original dictionary
            foreach (var pair in originalMap)
            {
                string key = pair.Key;
                int value = pair.Value;

                // If value exists in inverted map, add key to the list
                if (invertedMap.ContainsKey(value))
                {
                    invertedMap[value].Add(key);
                }
                else
                {
                    invertedMap[value] = new List<string> { key };
                }
            }

            return invertedMap;
        }

        static void Main()
        {
            // Sample input dictionary
            Dictionary<string, int> originalMap = new Dictionary<string, int>
            {
                { "A", 1 },
                { "B", 2 },
                { "C", 1 }
            };

            // Get inverted dictionary
            Dictionary<int, List<string>> invertedMap = InvertMap(originalMap);

            // Display output
            Console.WriteLine("Inverted Dictionary:");
            foreach (var pair in invertedMap)
            {
                Console.WriteLine($"{pair.Key} = [{string.Join(", ", pair.Value)}]");
            }
        }
    }
}

