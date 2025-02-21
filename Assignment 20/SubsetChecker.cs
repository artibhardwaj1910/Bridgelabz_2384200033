using System;
using System.Collections.Generic;
namespace CollectionsAssignment
{
    class SubsetChecker
    {
        // Method to check if set1 is a subset of set2
        static bool IsSubset(HashSet<int> set1, HashSet<int> set2)
        {
            return set1.IsSubsetOf(set2); // Returns true if set1 is a subset of set2
        }

        static void Main()
        {
            // Define two sets
            HashSet<int> set1 = new HashSet<int> { 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4 };

            // Check if set1 is a subset of set2
            bool result = IsSubset(set1, set2);

            // Display result
            Console.WriteLine("Is set1 a subset of set2? " + result);
        }
    }
}



Queue Interface Problems
1. Reverse a Queue
Reverse the elements of a queue using only queue operations.
Example:
Input: [10, 20, 30]
Output: [30, 20, 10]

using System;
using System.Collections.Generic;

namespace CollectionsAssignment
{
    class QueueReverser
    {
        // Method to reverse a queue
        static Queue<int> ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            // Step 1: Move all elements from queue to stack
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            // Step 2: Move all elements back from stack to queue (reversed order)
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }

        static void Main()
        {
            // Define a queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // Reverse the queue
            Queue<int> reversedQueue = ReverseQueue(queue);

            // Display result
            Console.WriteLine("Reversed Queue: [" + string.Join(", ", reversedQueue) + "]");
        }
    }
}

