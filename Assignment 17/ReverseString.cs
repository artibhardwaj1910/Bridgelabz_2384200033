using System;
using System.Text;
namespace StringBuilderAssignment
{
    class ReverseString
    {
        static void Main()
        {
            // Taking user input
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            // Using StringBuilder to reverse the string
            StringBuilder reversedString = new StringBuilder();

            // Looping through the string in reverse order
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reversedString.Append(inputString[i]);
            }

            // Displaying the reversed string
            Console.WriteLine("Reversed String: " + reversedString.ToString());
        }
    }
}

