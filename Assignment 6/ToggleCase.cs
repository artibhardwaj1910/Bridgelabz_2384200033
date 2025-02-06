using System;
namespace StringAssignment
{
    class ToggleCase
    {
        static void Main()
        {
            // Get user input
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int length = 0;

            // Find string length
            while (length < input.Length)
                length++;

            // Toggle case manually
            char[] toggled = new char[length];
            int i = 0;
            while (i < length)
            {
                char ch = input[i];

                if (ch >= 'A' && ch <= 'Z')
                    toggled[i] = (char)(ch + 32);
                else if (ch >= 'a' && ch <= 'z')
                    toggled[i] = (char)(ch - 32);
                else
                    toggled[i] = ch;

                i++;
            }

            // Display result
            Console.Write("Toggled String: ");
            i = 0;
            while (i < length)
            {
                Console.Write(toggled[i]);
                i++;
            }
            Console.WriteLine();
        }
    }
}

