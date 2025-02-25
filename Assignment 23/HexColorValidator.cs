using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Text.RegularExpressions;
 using System.Threading.Tasks;

 namespace RegexAssignment
 {
 	internal class HexColorValidator
 	{
     	// Prompts the user for a hex color code
     	public void InputMethod()
     	{
         	Console.Write("Enter a hex color code: ");
         	string hexColor = Console.ReadLine();
         	bool isValid = ValidateHexColor(hexColor); /
         	Console.WriteLine(isValid ? "Valid" : "Invalid"); // Output the result
     	}

     	// Validates the format of the hex color code
     	private bool ValidateHexColor(string color)
     	{
         	string pattern = @"^#[0-9A-Fa-f]{6}$";
         	return Regex.IsMatch(color, pattern);
     	}
 	}
 }

