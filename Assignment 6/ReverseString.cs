using System;
namespace StringAssignment{
    class ReverseString{
        static void Main()
        {
            // Get user input
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int length = 0;

            // Find string length
            while (input[length] != '\0' && length < input.Length)
                length++;

            // Reverse string manually
            char[] reversed = new char[length];
            int i = 0;
            while (i < length)
            {
                reversed[i] = input[length - i - 1];
                i++;
            }

            // Display reversed string
            Console.Write("Reversed String: ");
            i = 0;
            while (i < length)
            {
                Console.Write(reversed[i]);
                i++;
            }
            Console.WriteLine();
        }
    }
}

