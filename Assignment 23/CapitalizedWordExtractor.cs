using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Text.RegularExpressions;
 using System.Threading.Tasks;

 namespace RegexAssignment
 {
 	internal class CapitalizedWordExtractor
 	{
     	// Prompts the user for a sentence
     	public void InputMethod()
     	{
         	Console.Write("Enter a sentence: ");
         	string inputText = Console.ReadLine();
             ExtractCapitalizedWords(inputText); // Extract capitalized words from the input
     	}

     	// Extracts and displays capitalized words found in the input text
     	private void ExtractCapitalizedWords(string text)
     	{
         	string pattern = @"\b[A-Z][a-z]*\b"; // Regex pattern for capitalized words
         	MatchCollection matches = Regex.Matches(text, pattern);

         	if (matches.Count > 0)
         	{
             	Console.WriteLine("Extracted Capitalized Words:");
             	foreach (Match match in matches)
             	{
                 	Console.Write(match.Value + " "); // Print each found capitalized word
             	}
             	Console.WriteLine();
         	}
         	else
         	{
             	Console.WriteLine("No capitalized words found."); // Inform user if none found
         	}
     	}
 	}
 }

