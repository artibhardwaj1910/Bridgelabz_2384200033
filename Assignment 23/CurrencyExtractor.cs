using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Text.RegularExpressions;
 using System.Threading.Tasks;

 namespace RegexAssignment
 {
 	internal class CurrencyExtractor
 	{
     	// Prompts the user for text containing currency values
     	public void InputMethod()
     	{
         	Console.Write("Enter a text containing currency values: ");
         	string inputText = Console.ReadLine();
             ExtractCurrencyValues(inputText);
     	}

     	// Extracts and displays currency values found in the input text
     	private void ExtractCurrencyValues(string text)
     	{
         	string pattern = @"\$\s*\d+(\.\d{2})?";
         	MatchCollection matches = Regex.Matches(text, pattern);

         	if (matches.Count > 0)
         	{
             	Console.WriteLine("Extracted Currency Values:");
             	foreach (Match match in matches)
             	{
                 	Console.Write(match.Value.Trim() + " ");
             	}
             	Console.WriteLine();
         	}
         	else
         	{
             	Console.WriteLine("No currency values found.");
         	}
     	}
 	}
 }

