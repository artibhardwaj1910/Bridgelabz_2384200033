using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Text.RegularExpressions;
 using System.Threading.Tasks;

 namespace RegexAssignment
 {
 	internal class DateExtractor
 	{
     	// Prompts the user for text containing dates in the format dd/mm/yyyy
     	public void InputMethod()
     	{
         	Console.Write("Enter a text containing dates (dd/mm/yyyy): ");
         	string inputText = Console.ReadLine();
         	ExtractDates(inputText); // Extract dates from the input text
     	}

     	// Extracts and displays dates found in the input text
     	private void ExtractDates(string text)
     	{
         	string pattern = @"\b(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/[0-9]{4}\b"; // Regex pattern for matching dates
         	MatchCollection matches = Regex.Matches(text, pattern);

         	if (matches.Count > 0)
         	{
             	Console.WriteLine("Extracted Dates:");
             	foreach (Match match in matches)
             	{
                 	Console.Write(match.Value + " "); // Print each found date
             	}
             	Console.WriteLine();
         	}
         	else
         	{
             	Console.WriteLine("No dates found."); // Inform user if none found
         	}
     	}
 	}
 }

