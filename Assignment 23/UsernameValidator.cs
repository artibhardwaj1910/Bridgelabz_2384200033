using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Text.RegularExpressions;
 using System.Threading.Tasks;

 namespace RegexAssignment
 {
 	internal class UsernameValidator
 	{
     	// Method to take user input and validate username
     	public void InputMethod()
     	{
         	Console.Write("Enter a username: ");
         	string username = Console.ReadLine();
         	bool isValid = ValidateUsername(username);
         	Console.WriteLine(isValid ? "Valid" : "Invalid");
     	}

     	// Method to check if username meets regex criteria
     	private bool ValidateUsername(string username)
     	{
         	string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
         	return Regex.IsMatch(username, pattern);
     	}
 	}
 }

