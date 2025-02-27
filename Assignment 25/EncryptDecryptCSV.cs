using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CSVDataHandlingAssignment
{
    class EncryptDecryptCSV
    {
        static string key = "A1B2C3D4E5F6G7H8"; 

        static void Main()
        {
            string csvFile = "employees_encrypted.csv";

            List<Employee> employees = new List<Employee>
            {
                new Employee { ID = "1", Name = "John", Email = "john@example.com", Salary = "50000" },
                new Employee { ID = "2", Name = "Alice", Email = "alice@example.com", Salary = "60000" },
                new Employee { ID = "3", Name = "Bob", Email = "bob@example.com", Salary = "55000" }
            };

            // Encrypt and write to CSV
            WriteEncryptedCSV(csvFile, employees);

            // Read and Decrypt CSV
            ReadDecryptedCSV(csvFile);
        }

        static void WriteEncryptedCSV(string filePath, List<Employee> employees)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Name,Email,Salary"); // CSV Header
                foreach (var emp in employees)
                {
                    string encryptedEmail = Encrypt(emp.Email);
                    string encryptedSalary = Encrypt(emp.Salary);
                    writer.WriteLine($"{emp.ID},{emp.Name},{encryptedEmail},{encryptedSalary}");
                }
            }

            Console.WriteLine($"Encrypted CSV File Created: {filePath}");
        }

        static void ReadDecryptedCSV(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("CSV file not found.");
                return;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader) { isHeader = false; continue; } // Skip Header

                    string[] values = line.Split(',');
                    string decryptedEmail = Decrypt(values[2]);
                    string decryptedSalary = Decrypt(values[3]);

                    Console.WriteLine($"ID: {values[0]}, Name: {values[1]}, Email: {decryptedEmail}, Salary: {decryptedSalary}");
                }
            }
        }

        static string Encrypt(string text)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = new byte[16]; // Default IV

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] inputBytes = Encoding.UTF8.GetBytes(text);
                byte[] encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

                return Convert.ToBase64String(encryptedBytes);
            }
        }

        static string Decrypt(string cipherText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = new byte[16]; // Default IV

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                byte[] decryptedBytes = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);

                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }

    class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Salary { get; set; }
    }
}
