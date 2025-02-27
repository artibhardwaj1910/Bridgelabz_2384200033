using System;
using System.IO;

namespace CSVDataHandlingAssignment
{
    class ReadNCountRows
    {
        public void CountRows()
        {
            string filePath = "employees.csv";

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length > 1)
                {
                    int recordCount = lines.Length - 1; 
                    Console.WriteLine($"Number of records (excluding header): {recordCount}");
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