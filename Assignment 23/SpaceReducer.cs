using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Text.RegularExpressions;
 using System.Threading.Tasks;

 namespace RegexAssignment
 {
 	internal class SpaceReducer
 	{
     	// Prompts the user for a sentence and processes it to reduce multiple spaces
     	public void InputMethod()
     	{
         	Console.Write("Enter a sentence with multiple spaces: ");
         	string inputText = Console.ReadLine();
         	string result = ReplaceMultipleSpaces(inputText);
         	Console.WriteLine("Modified Output: " + result);
     	}

     	// Replaces multiple consecutive whitespace characters with a single space
     	private string ReplaceMultipleSpaces(string text)
     	{
         	return Regex.Replace(text, @"\s+", " ");
     	}
 	}
 }

