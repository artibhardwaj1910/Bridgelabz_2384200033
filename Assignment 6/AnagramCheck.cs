using System;
namespace StringAssignment
{
    class AnagramCheck
    {
        static void Main()
        {
            // Get user input
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            int len1 = 0, len2 = 0;

            // Find string lengths
            while (len1 < str1.Length)
                len1++;
            while (len2 < str2.Length)
                len2++;

            if (len1 != len2)
            {
                Console.WriteLine("Strings are not anagrams.");
                return;
            }

            // Count frequency of characters
            int[] frequency = new int[256];
            int i = 0;
            while (i < len1)
            {
                frequency[str1[i]]++;
                frequency[str2[i]]--;
                i++;
            }

            // Check if all counts are zero
            i = 0;
            while (i < 256)
            {
                if (frequency[i] != 0)
                {
                    Console.WriteLine("Strings are not anagrams.");
                    return;
                }
                i++;
            }

            Console.WriteLine("Strings are anagrams.");
        }
    }
}

