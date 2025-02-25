using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Text.RegularExpressions;
 using System.Threading.Tasks;

 namespace RegexAssignment
 {
 	internal class EmailExtractor
 	{
     	// Prompts the user for text containing email addresses
     	public void InputMethod()
     	{
         	Console.Write("Enter a text containing email addresses: ");
         	string inputText = Console.ReadLine();
         	ExtractEmails(inputText);
     	}

     	// Extracts and displays email addresses found in the input text
     	private void ExtractEmails(string text)
     	{
         	string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
         	MatchCollection matches = Regex.Matches(text, pattern);

         	if (matches.Count > 0)
         	{
      	       Console.WriteLine("Extracted Email Addresses:");
             	foreach (Match match in matches)
             	{
                     Console.WriteLine(match.Value); // Print each found email address
             	}
         	}
         	else
         	{
             	Console.WriteLine("No email addresses found.");
         	}
     	}
 	}
 }

