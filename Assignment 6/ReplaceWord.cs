using System;
namespace StringAssignment
{
    class ReplaceWord
    {
        static void Main()
        {
            // Get user input
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.Write("Enter word to replace: ");
            string oldWord = Console.ReadLine();

            Console.Write("Enter new word: ");
            string newWord = Console.ReadLine();

            int sentLength = 0, oldWordLength = 0, newWordLength = 0;

            // Find lengths
            while (sentLength < sentence.Length)
                sentLength++;
            while (oldWordLength < oldWord.Length)
                oldWordLength++;
            while (newWordLength < newWord.Length)
                newWordLength++;

            // Replace word manually
            char[] modified = new char[sentLength + newWordLength - oldWordLength];
            int i = 0, index = 0;
            while (i < sentLength)
            {
                bool match = true;
                int j = 0;
                while (j < oldWordLength)
                {
                    if (i + j >= sentLength || sentence[i + j] != oldWord[j])
                    {
                        match = false;
                        break;
                    }
                    j++;
                }

                if (match)
                {
                    int k = 0;
                    while (k < newWordLength)
                    {
                        modified[index] = newWord[k];
                        index++;
                        k++;
                    }
                    i += oldWordLength;
                }
                else
                {
                    modified[index] = sentence[i];
                    index++;
                    i++;
                }
            }

            // Display result
            Console.Write("Modified Sentence: ");
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

