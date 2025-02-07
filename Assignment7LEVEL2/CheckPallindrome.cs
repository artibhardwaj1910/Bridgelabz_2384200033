using System;
namespace FunctionAssignment
{
    class Program
    {
        static bool CheckPalindrome(string str)
        {
            int len = str.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - 1 - i]) 
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            bool isPalindrome = CheckPalindrome(input);
            if (isPalindrome) 
            {
                Console.WriteLine("It is a palindrome.");
            }
            else 
            {
                Console.WriteLine("It is not a palindrome.");
            }
        }
    }
}

