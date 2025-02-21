using System;
using System.Collections.Generic;
namespace CollectionsAssignment
{
    class RemoveDuplicates
    {
        // Method to remove duplicates while preserving order
        static List<int> RemoveDuplicateElements(List<int> numbers)
        {
            HashSet<int> seenNumbers = new HashSet<int>(); // Stores unique elements
            List<int> resultList = new List<int>(); // Stores the final list

            foreach (int num in numbers)
            {
                if (!seenNumbers.Contains(num)) // If not already seen, add to result
                {
                    seenNumbers.Add(num);
                    resultList.Add(num);
                }
            }

            return resultList;
        }

        static void Main()
        {
            // Input list with duplicates
            List<int> numbers = new List<int> { 3, 1, 2, 2, 3, 4 };

            // Remove duplicates
            List<int> uniqueNumbers = RemoveDuplicateElements(numbers);

            // Display the result
            Console.WriteLine("List after removing duplicates: " + string.Join(", ", uniqueNumbers));
        }
    }
}

