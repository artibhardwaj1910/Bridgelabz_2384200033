using System;
using System.Collections.Generic;
using System.IO;

namespace CSVDataHandlingAssignment
{
    class DetectDuplicateCSV
    {
        static void Main()
        {
            string filePath = "students.csv"; // CSV file path

            if (!File.Exists(filePath))
            {
                Console.WriteLine("CSV file not found.");
                return;
            }

            Dictionary<string, string> studentRecords = new Dictionary<string, string>(); // Store unique records
            List<string> duplicateRecords = new List<string>(); // Store duplicate records

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader) // Skip header row
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] values = line.Split(',');

                    if (values.Length > 0)
                    {
                        string id = values[0];

                        if (studentRecords.ContainsKey(id))
                        {
                            duplicateRecords.Add(line); // Add duplicate record
                        }
                        else
                        {
                            studentRecords[id] = line; // Store unique record
                        }
                    }
                }
            }

            // Display duplicate records
            if (duplicateRecords.Count > 0)
            {
                Console.WriteLine("Duplicate Records Found:");
                foreach (var record in duplicateRecords)
                {
                    Console.WriteLine(record);
                }
            }
            else
            {
                Console.WriteLine("No duplicate records found.");
            }
        }
    }
}
