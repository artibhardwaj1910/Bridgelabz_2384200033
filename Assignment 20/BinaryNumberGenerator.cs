using System;
using System.Collections.Generic;
namespace CollectionsAssignment
{
    class BinaryNumberGenerator
    {
        // Method to generate the first N binary numbers using a queue
        static List<string> GenerateBinaryNumbers(int n)
        {
            List<string> result = new List<string>();
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("1"); // Start with "1"

            for (int i = 0; i < n; i++)
            {
                string current = queue.Dequeue();
                result.Add(current); // Store the binary number

                // Generate next two binary numbers
                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }

            return result;
        }

        static void Main()
        {
            // Get user input
            Console.Write("Enter the number of binary numbers to generate: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Generate binary numbers
            List<string> binaryNumbers = GenerateBinaryNumbers(n);

            // Display result
            Console.WriteLine("Binary Numbers: {" + string.Join(", ", binaryNumbers) + "}");
        }
    }
}

