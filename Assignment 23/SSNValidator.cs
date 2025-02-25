using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Text.RegularExpressions;
 using System.Threading.Tasks;

 namespace RegexAssignment
 {
 	internal class SSNValidator
 	{
     	// Prompts the user for an SSN and validates it
     	public void InputMethod()
     	{
         	Console.Write("Enter a Social Security Number (SSN): ");
         	string ssn = Console.ReadLine();
         	bool isValid = ValidateSSN(ssn);
         	Console.WriteLine(isValid ? $"✅ \"{ssn}\" is valid" : $"❌ \"{ssn}\" is invalid");
     	}

     	// Validates the SSN format as "XXX-XX-XXXX"
     	private bool ValidateSSN(string ssn)
     	{
         	string pattern = @"^\d{3}-\d{2}-\d{4}$";
         	return Regex.IsMatch(ssn, pattern);
     	}
 	}
 }

