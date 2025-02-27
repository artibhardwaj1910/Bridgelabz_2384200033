using System;
using System.IO;

namespace CSVDataHandlingAssignment
{
    class FilterRecords
    {
        public void FilterStudents()
        {
            string filePath = "students.csv"; 

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length > 1)
                {
                    Console.WriteLine("Students who scored more than 80 marks:");
                    Console.WriteLine("ID\tName\t\tMarks");
                    Console.WriteLine("-----------------------------");

                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] fields = lines[i].Split(',');

                        int marks = int.Parse(fields[3]); 
                        if (marks > 80)
                        {
                            Console.WriteLine($"{fields[0]}\t{fields[1]}\t{fields[3]}");
                        }
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