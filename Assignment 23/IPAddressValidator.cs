using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Text.RegularExpressions;
 using System.Threading.Tasks;

 namespace RegexAssignment
 {
 	internal class IPAddressValidator
 	{
     	// Prompts the user for an IP address
     	public void InputMethod()
     	{
         	Console.Write("Enter an IP address: ");
         	string ipAddress = Console.ReadLine();
         	bool isValid = ValidateIPAddress(ipAddress); // Validate the input IP address
         	Console.WriteLine(isValid ? "Valid IP Address" : "Invalid IP Address"); // Output the result
     	}

     	// Validates the format of the IP address
     	private bool ValidateIPAddress(string ip)
     	{
         	// Regex pattern for matching a valid IPv4 address
         	string pattern = @"\b(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\b";
         	return Regex.IsMatch(ip, pattern); // Check if the IP matches the pattern
     	}
 	}
 }

