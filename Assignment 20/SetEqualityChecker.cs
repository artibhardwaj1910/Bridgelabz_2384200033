using System;
using System.Collections.Generic;
namespace CollectionsAssignment
{
    class SetEqualityChecker
    {
        // Method to check if two sets are equal
        static bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2)
        {
            return set1.SetEquals(set2); // Returns true if both sets contain the same elements
        }

        static void Main()
        {
            // Define two sets
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 2, 1 };

            // Check equality
            bool result = AreSetsEqual(set1, set2);

            // Display result
            Console.WriteLine("Are the two sets equal? " + result);
        }
    }
}

