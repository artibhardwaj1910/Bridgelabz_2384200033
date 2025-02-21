using System;
using System.Collections.Generic;
namespace CollectionsAssignment
{
    class SymmetricDifferenceFinder
    {
        // Method to compute the symmetric difference of two sets
        static HashSet<int> GetSymmetricDifference(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> result = new HashSet<int>(set1);
            result.SymmetricExceptWith(set2); // Removes common elements and keeps unique ones
            return result;
        }

        static void Main()
        {
            // Define two sets
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            // Compute symmetric difference
            HashSet<int> symmetricDifference = GetSymmetricDifference(set1, set2);

            // Display result
            Console.WriteLine("Symmetric Difference: {" + string.Join(", ", symmetricDifference) + "}");
        }
    }
}

