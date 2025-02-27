using System;
using System.IO;

namespace CSVDataHandlingAssignment
{
    class ReadLargeCSV
    {
        static void Main()
        {
            string filePath = "large_students.csv"; // Large CSV file

            if (!File.Exists(filePath))
            {
                Console.WriteLine("CSV file not found.");
                return;
            }

            int batchSize = 100; // Read 100 lines at a time
            int totalRecords = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                int lineCount = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line); // Process each line (Can be stored in a list if needed)
                    lineCount++;
                    totalRecords++;

                    if (lineCount == batchSize)
                    {
                        Console.WriteLine($"Processed {totalRecords} records so far...");
                        lineCount = 0; // Reset count for next batch
                    }
                }
            }

            Console.WriteLine($"Total records processed: {totalRecords}");
        }
    }
}
