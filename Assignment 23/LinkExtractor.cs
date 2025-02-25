using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Text.RegularExpressions;
 using System.Threading.Tasks;

 namespace RegexAssignment
 {
 	internal class LinkExtractor
 	{
     	// Prompts the user for text containing URLs
     	public void InputMethod()
     	{
         	Console.Write("Enter a text containing URLs: ");
         	string inputText = Console.ReadLine();
         	ExtractLinks(inputText);
     	}

     	// Extracts and displays URLs found in the input text
     	private void ExtractLinks(string text)
     	{
         	string pattern = @"\bhttps?:\/\/[^\s]+"; // Regex pattern to match URLs
         	MatchCollection matches = Regex.Matches(text, pattern);

         	if (matches.Count > 0)
         	{
             	Console.WriteLine("Extracted Links:");
             	foreach (Match match in matches)
             	{
                     Console.WriteLine(match.Value); // Print each found URL
             	}
         	}
         	else
         	{
             	Console.WriteLine("No links found."); // Inform user if none found
         	}
     	}
 	}
 }

