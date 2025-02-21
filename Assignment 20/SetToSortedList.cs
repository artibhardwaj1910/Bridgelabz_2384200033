using System;
using System.Collections.Generic;
namespace CollectionsAssignment
{
    class SetToSortedList
    {
        // Method to convert a set into a sorted list
        static List<int> ConvertToSortedList(HashSet<int> set)
        {
            List<int> sortedList = new List<int>(set); // Convert set to list
            sortedList.Sort(); // Sort in ascending order
            return sortedList;
        }

        static void Main()
        {
            // Define a set
            HashSet<int> numberSet = new HashSet<int> { 5, 3, 9, 1 };

            // Convert to sorted list
            List<int> sortedList = ConvertToSortedList(numberSet);

            // Display result
            Console.WriteLine("Sorted List: [" + string.Join(", ", sortedList) + "]");
        }
    }
}

