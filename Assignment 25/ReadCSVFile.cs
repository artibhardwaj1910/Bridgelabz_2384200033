using System;
using System.IO;

namespace CSVDataHandlingAssignment
{
    class ReadCSVFile
    {
        public void ReadLines()
        {
 
            string filePath = "students.csv";

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                Console.WriteLine("ID\tName\t\tAge\tMarks");

                for (int i = 1; i < lines.Length; i++) 
                {
                    string[] fields = lines[i].Split(',');

                    Console.WriteLine($"{fields[0]}\t{fields[1]}\t{fields[2]}\t{fields[3]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}