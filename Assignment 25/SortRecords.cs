using System;
using System.IO;

namespace CSVDataHandlingAssignment
{
    class SortRecords
    {
        static void SortColumns()
        {
            string filePath = "employees.csv"; 

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length > 1)
                {
                    string[][] employees = new string[lines.Length - 1][];

                    for (int i = 1; i < lines.Length; i++)
                    {
                        employees[i - 1] = lines[i].Split(','); 
                    }

                    Array.Sort(employees, (x, y) => Convert.ToDouble(y[3]).CompareTo(Convert.ToDouble(x[3])));

                    Console.WriteLine("Top 5 Highest-Paid Employees:");
                    Console.WriteLine("ID\tName\t\tDepartment\tSalary");
                    Console.WriteLine("---------------------------------------------");

                    for (int i = 0; i < Math.Min(5, employees.Length); i++) 
                    {
                        Console.WriteLine($"{employees[i][0]}\t{employees[i][1]}\t{employees[i][2]}\t{employees[i][3]}");
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