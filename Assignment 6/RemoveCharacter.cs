using System;
namespace StringAssignment
{
    class RemoveCharacter
    {
        static void Main()
        {
            // Get user input
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter a character to remove: ");
            char toRemove = Console.ReadLine()[0];

            int length = 0;
            while (length < input.Length)
                length++;

            // Remove character manually
            char[] modified = new char[length];
            int index = 0, i = 0;
            while (i < length)
            {
                if (input[i] != toRemove)
                {
                    modified[index] = input[i];
                    index++;
                }
                i++;
            }

            // Display result
            Console.Write("Modified String: ");
            i = 0;
            while (i < index)
            {
                Console.Write(modified[i]);
                i++;
            }
            Console.WriteLine();
        }
    }
}

