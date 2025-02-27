using System;
using System.IO;
using System.Text.RegularExpressions;

namespace CSVDataHandlingAssignment
{
    class ValidateCSVData
    {
        public void ValidateCSV()
        {
            string filePath = "contacts.csv"; 

            if (!File.Exists(filePath)) 
            {
                Console.WriteLine("CSV file not found.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("Validating CSV Data...\n");

            for (int i = 0; i < lines.Length; i++) 
            {
                string[] values = lines[i].Split(','); 

                if (values.Length < 3) 
                {
                    Console.WriteLine($"Error in row {i + 1}: Missing values -> {lines[i]}");
                    continue;
                }

                string email = values[1]; 
                string phoneNumber = values[2]; 

                if (!IsValidEmail(email)) 
                {
                    Console.WriteLine($"Error in row {i + 1}: Invalid Email -> {email}");
                }

                if (!IsValidPhoneNumber(phoneNumber))
                {
                    Console.WriteLine($"Error in row {i + 1}: Invalid Phone Number -> {phoneNumber}");
                }
            }

            Console.WriteLine("\nCSV Validation Completed.");
        }

        static bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; 
            return Regex.IsMatch(email, pattern);
        }

        static bool IsValidPhoneNumber(string phone)
        {
            string pattern = @"^\d{10}$"; 
            return Regex.IsMatch(phone, pattern);
        }
    }
}
