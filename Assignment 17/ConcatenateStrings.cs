using System;
using System.Text;
namespace StringBuilderAssignment
{
    class ConcatenateStrings
    {
        static void Main()
        {
            // Taking user input for the number of strings
            Console.Write("Enter the number of strings: ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Declaring an array to store the strings
            string[] stringArray = new string[size];

            // Taking input for each string
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter string " + (i + 1) + ": ");
                stringArray[i] = Console.ReadLine();
            }

            // Using StringBuilder for efficient concatenation
            StringBuilder concatenatedString = new StringBuilder();

            // Using foreach loop to append each string
            foreach (string str in stringArray)
            {
                concatenatedString.Append(str);
            }

            // Displaying the concatenated result
            Console.WriteLine("Concatenated String: " + concatenatedString.ToString());
        }
    }
}

