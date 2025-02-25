using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Text.RegularExpressions;
 using System.Threading.Tasks;

 namespace RegexAssignment
 {
 	internal class LicensePlateValidator
 	{
     	// Prompts the user for a license plate number
     	public void InputMethod()
     	{
         	Console.Write("Enter a license plate number: ");
         	string licensePlate = Console.ReadLine();
         	bool isValid = ValidateLicensePlate(licensePlate);
      	   Console.WriteLine(isValid ? "Valid" : "Invalid"); // Output the result
     	}

     	// Validates the license plate format (2 uppercase letters followed by 4 digits)
     	private bool ValidateLicensePlate(string plate)
     	{
         	string pattern = @"^[A-Z]{2}\d{4}$";
         	return Regex.IsMatch(plate, pattern);
     	}
 	}
 }

