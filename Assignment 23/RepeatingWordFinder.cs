using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Text.RegularExpressions;
 using System.Threading.Tasks;

 namespace RegexAssignment
 {
 	internal class RepeatingWordFinder
 	{
     	// Prompts the user for a sentence and processes it
     	public void InputMethod()
     	{
         	Console.Write("Enter a sentence: ");
         	string inputText = Console.ReadLine();
             FindRepeatingWords(inputText);
     	}

     	// Finds and displays words that repeat in the given text
     	private void FindRepeatingWords(string text)
     	{
         	string pattern = @"\b(\w+)\b"; // Pattern to match whole words
         	MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

         	Dictionary<string, int> wordCounts = new Dictionary<string, int>();

         	foreach (Match match in matches)
         	{
             	string word = match.Value.ToLower();
             	if (wordCounts.ContainsKey(word))
                 	wordCounts[word]++;
             	else
                 	wordCounts[word] = 1;
         	}

         	Console.WriteLine("Repeating Words:");
         	bool found = false;
         	foreach (var pair in wordCounts)
         	{
             	if (pair.Value > 1)
             	{
                     Console.Write(pair.Key + " ");
                 	found = true;
             	}
         	}

         	// Inform the user if no repeating words were found
         	if (!found)
             	Console.WriteLine("No repeating words found.");
         	else
             	Console.WriteLine();
     	}
 	}
 }

