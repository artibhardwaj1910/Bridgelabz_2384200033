using System;
using System.IO;
namespace CSVDataHandlingAssignment
{
    class CreateCSVFile
    {
        public void WriteLines()
        {
            string filePath = "employees.csv"; 

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Name,Department,Salary"); 

                while (true)
                {
                    Console.WriteLine("Enter employee details (or type 'exit' to finish):");

                    Console.Write("ID: ");
                    string id = Console.ReadLine();

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Department: ");
                    string department = Console.ReadLine();

                    Console.Write("Salary: ");
                    string salary = Console.ReadLine();

                    writer.WriteLine($"{id},{name},{department},{salary}");
                }
            }

            Console.WriteLine("Employee data written to CSV file successfully.");
        }
    }
}