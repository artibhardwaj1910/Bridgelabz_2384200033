using System;
namespace LinearSearchAssignment
{
    class SearchWordInSentences
    {
        static void Main()
        {
            // Declare an array of sentences
            string[] sentences = 
            {
                "The sun rises in the east.",
                "C# is a powerful programming language.",
                "This is a simple linear search example.",
                "The weather is pleasant today."
            };

            // Ask the user for the word to search
            Console.Write("Enter the word to search: ");
            string searchWord = Console.ReadLine();

            // Variable to store the first matching sentence
            string foundSentence = "";

            // Perform Linear Search
            foreach (string sentence in sentences)
            {
                int index = 0;
                while (index <= sentence.Length - searchWord.Length)
                {
                    int i = 0;
                    while (i < searchWord.Length && sentence[index + i] == searchWord[i])
                    {
                        i++;
                    }

                    if (i == searchWord.Length && 
                        (index + i == sentence.Length || sentence[index + i] == ' '))
                    {
                        foundSentence = sentence;
                        break;
                    }
                    index++;
                }

                if (foundSentence != "")
                {
                    break; // Stop after finding the first matching sentence
                }
            }

            // Display the result
            if (foundSentence != "")
            {
                Console.WriteLine($"The first sentence containing '{searchWord}' is:\n{foundSentence}");
            }
            else
            {
                Console.WriteLine($"No sentence contains the word '{searchWord}'.");
            }
        }
    }
}

