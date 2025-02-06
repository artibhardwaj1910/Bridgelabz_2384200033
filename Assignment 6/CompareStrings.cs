using System;
namespace StringAssignment
{
    class CompareStrings
    {
        static void Main()
        {
            // Get user input
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            int i = 0;
            while (str1[i] != '\0' && str2[i] != '\0' && str1[i] == str2[i])
                i++;

            if (str1[i] == str2[i])
                Console.WriteLine("Both strings are equal.");
            else if (str1[i] < str2[i])
                Console.WriteLine("\"" + str1 + "\" comes before \"" + str2 + "\" in lexicographical order.");
            else
                Console.WriteLine("\"" + str1 + "\" comes after \"" + str2 + "\" in lexicographical order.");
        }
    }
}

