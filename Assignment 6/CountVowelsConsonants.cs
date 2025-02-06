using System;
namespace StringAssignment{
    class CountVowelsConsonants{
        static void Main()
        {
            // Get user input
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int length = 0;

            // Count vowels and consonants
            int vowelsCount = 0, consonantsCount = 0;
            while (length < input.Length)
            {
                char ch = input[length];

                // Convert to lowercase for uniformity
                if (ch >= 'A' && ch <= 'Z')
                {
                    ch = (char)(ch + 32);
                }

                if ((ch >= 'a' && ch <= 'z'))
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                        vowelsCount++;
                    else
                        consonantsCount++;
                }
                length++;
            }

            // Display result
            Console.WriteLine("Vowels: " + vowelsCount);
            Console.WriteLine("Consonants: " + consonantsCount);
        }
    }
}

