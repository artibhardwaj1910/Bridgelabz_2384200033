using System;
using System.IO;
namespace CSVDataHandlingAssignment
{
    class UpdateValue
    {
        public void UpdateRecords()
        {
            string inputFilePath = "employees.csv"; 
            string outputFilePath = "updated_employees.csv"; 

            try
            {
                string[] lines = File.ReadAllLines(inputFilePath);

                string[] updatedRecords = new string[lines.Length];

                updatedRecords[0] = lines[0]; 

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');

                    if (fields[2].Equals("IT", StringComparison.OrdinalIgnoreCase)) 
                    {
                        string salaryString = fields[3]; 
                        double salary = Convert.ToDouble(salaryString); 
                        salary *= 1.10; 
                        fields[3] = salary.ToString("F2"); 
                    }

                    updatedRecords[i] = string.Join(",", fields);
                }

                File.WriteAllLines(outputFilePath, updatedRecords);
                Console.WriteLine("Updated employee records saved to " + outputFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}