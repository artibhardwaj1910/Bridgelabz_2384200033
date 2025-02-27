using System;
using System.IO;

namespace CSVDataHandlingAssignment
{
    class SearchRecord
    {
        public void Record()
        {
            string filePath = "employees.csv"; 

            Console.Write("Enter the name of the employee to search: ");
            string searchName = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length > 1)
                {
                    bool found = false; 

                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] fields = lines[i].Split(',');

                        if (fields[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Department: {fields[2]}, Salary: {fields[3]}");
                            found = true; 
                            break; 
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Employee not found.");
                    }
                }
                else
                {
                    Console.WriteLine("The CSV file is empty or only contains the header.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}