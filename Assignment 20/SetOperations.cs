using System;
using System.Collections.Generic;
namespace CollectionsAssignment
{
    class SetOperations
    {
        // Method to compute the union of two sets
        static HashSet<int> GetUnion(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> unionSet = new HashSet<int>(set1);
            unionSet.UnionWith(set2); // Adds all elements from set2
            return unionSet;
        }

        // Method to compute the intersection of two sets
        static HashSet<int> GetIntersection(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> intersectionSet = new HashSet<int>(set1);
            intersectionSet.IntersectWith(set2); // Keeps only common elements
            return intersectionSet;
        }

        static void Main()
        {
            // Define two sets
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            // Compute union and intersection
            HashSet<int> unionResult = GetUnion(set1, set2);
            HashSet<int> intersectionResult = GetIntersection(set1, set2);

            // Display results
            Console.WriteLine("Union: {" + string.Join(", ", unionResult) + "}");
            Console.WriteLine("Intersection: {" + string.Join(", ", intersectionResult) + "}");
        }
    }
}

