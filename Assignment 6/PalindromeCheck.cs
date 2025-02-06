using System;
namespace StringAssignment{
    class PalindromeCheck{
        static void Main()
        {
            // Get user input
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int length = 0;

            // Find string length
            while (input[length] != '\0' && length < input.Length)
                length++;

            // Check for palindrome
            int i = 0;
            bool isPalindrome = true;
            while (i < length / 2)
            {
                if (input[i] != input[length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
                i++;
            }

            // Display result
            if (isPalindrome)
                Console.WriteLine("The string is a palindrome.");
            else
                Console.WriteLine("The string is not a palindrome.");
        }
    }
}

