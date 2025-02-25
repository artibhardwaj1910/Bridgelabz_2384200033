using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Text.RegularExpressions;
 using System.Threading.Tasks;

 namespace RegexAssignment
 {
 	internal class CreditCardValidator
 	{
     	// Prompts the user for a credit card number
     	public void InputMethod()
     	{
         	Console.Write("Enter a credit card number: ");
         	string cardNumber = Console.ReadLine();
         	string result = ValidateCreditCard(cardNumber); // Validate the card number
         	Console.WriteLine(result); // Output the result
     	}

     	// Validates the credit card number and identifies the card type
     	private string ValidateCreditCard(string cardNumber)
     	{
         	string visaPattern = @"^4\d{15}$";  	// Visa: Starts with 4, 16 digits
         	string masterCardPattern = @"^5\d{15}$"; // MasterCard: Starts with 5, 16 digits

         	if (Regex.IsMatch(cardNumber, visaPattern))
             	return "Valid Visa Card";
         	else if (Regex.IsMatch(cardNumber, masterCardPattern))
             	return "Valid MasterCard";
         	else
             	return "Invalid Card Number";
     	}
 	}
 }

