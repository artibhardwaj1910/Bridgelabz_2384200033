using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Text.RegularExpressions;
 using System.Threading.Tasks;

 namespace RegexAssignment
 {
 	internal class BadWordCensor
 	{
     	private readonly string[] badWords = { "damn", "stupid" }; // List of bad words to censor

     	// Prompts the user for a sentence and censors bad words
     	public void InputMethod()
     	{
         	Console.Write("Enter a sentence: ");
         	string inputText = Console.ReadLine();
         	string result = CensorBadWords(inputText);
         	Console.WriteLine("Censored Output: " + result);
     	}

     	// Censors bad words in the provided text
     	private string CensorBadWords(string text)
     	{
         	foreach (string word in badWords)
         	{
         	    string pattern = $@"\b{word}\b";
             	text = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);
         	}
         	return text;
     	}
 	}
 }

