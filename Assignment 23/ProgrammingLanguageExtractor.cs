using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Text.RegularExpressions;
 using System.Threading.Tasks;

 namespace RegexAssignment
 {
 	internal class ProgrammingLanguageExtractor
 	{
     	private readonly string[] languages = { "JavaScript", "Java", "Python", "C#", "C++", "Ruby", "Swift", "Go", "Kotlin", "PHP", "TypeScript", "Rust", "Perl" };

     	// Prompts the user for a sentence containing programming languages
     	public void InputMethod()
     	{
         	Console.Write("Enter a sentence containing programming languages: ");
         	string inputText = Console.ReadLine();
             ExtractLanguages(inputText);
     	}

     	// Extracts and displays programming languages found in the input text
     	private void ExtractLanguages(string text)
     	{
             string pattern = @"\b(JavaScript|Java|Python|C\+\+|C#|Ruby|Swift|Go|Kotlin|PHP|TypeScript|Rust|Perl)\b"; // Regex pattern for programming languages
         	MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

         	if (matches.Count > 0)
         	{
             	Console.WriteLine("Extracted Programming Languages:");
             	foreach (Match match in matches)
             	{
                     Console.Write(match.Value + " "); // Print each found language
             	}
             	Console.WriteLine();
         	}
         	else
         	{
             	Console.WriteLine("No programming languages found."); // Inform user if none found
         	}
     	}
 	}
 }

