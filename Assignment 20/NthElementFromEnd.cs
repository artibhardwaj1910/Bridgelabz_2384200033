using System;
using System.Collections.Generic;
namespace CollectionsAssignment
{
    class NthElementFromEnd
    {
        // Method to find the Nth element from the end in a LinkedList
        static string FindNthFromEnd(LinkedList<string> list, int n)
        {
            LinkedListNode<string> first = list.First;
            LinkedListNode<string> second = list.First;

            // Move the first pointer N steps ahead
            for (int i = 0; i < n; i++)
            {
                if (first == null)
                {
                    return "Invalid input: N is larger than the list size.";
                }
                first = first.Next;
            }

            // Move both pointers one step at a time
            while (first != null)
            {
                first = first.Next;
                second = second.Next;
            }

            return second.Value; // The Nth element from the end
        }

        static void Main()
        {
            // Creating a LinkedList
            LinkedList<string> letters = new LinkedList<string>(new string[] { "A", "B", "C", "D", "E" });

            // Find the 2nd element from the end
            int n = 2;
            string result = FindNthFromEnd(letters, n);

            // Display the result
            Console.WriteLine($"The {n}th element from the end is: {result}");
        }
    }
}

