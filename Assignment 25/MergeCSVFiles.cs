using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSVDataHandlingAssignment
{
    class MergeCSVFiles
    {
        static void Main()
        {
            string file1 = "students1.csv"; // First CSV file
            string file2 = "students2.csv"; // Second CSV file
            string outputFile = "merged_students.csv"; // Output merged file

            if (!File.Exists(file1) || !File.Exists(file2))
            {
                Console.WriteLine("One or both input CSV files are missing.");
                return;
            }

            Dictionary<string, string[]> studentData1 = new Dictionary<string, string[]>(); // Stores (ID -> [Name, Age])
            Dictionary<string, string[]> studentData2 = new Dictionary<string, string[]>(); // Stores (ID -> [Marks, Grade])

            // Read students1.csv (ID, Name, Age)
            foreach (var line in File.ReadLines(file1))
            {
                string[] values = line.Split(',');
                if (values.Length < 3) continue; // Skip invalid rows
                studentData1[values[0]] = new string[] { values[1], values[2] };
            }

            // Read students2.csv (ID, Marks, Grade)
            foreach (var line in File.ReadLines(file2))
            {
                string[] values = line.Split(',');
                if (values.Length < 3) continue; // Skip invalid rows
                studentData2[values[0]] = new string[] { values[1], values[2] };
            }

            // Merge data based on ID and write to output file
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine("ID,Name,Age,Marks,Grade"); // Header

                foreach (var id in studentData1.Keys)
                {
                    if (studentData2.ContainsKey(id))
                    {
                        writer.WriteLine($"{id},{studentData1[id][0]},{studentData1[id][1]},{studentData2[id][0]},{studentData2[id][1]}");
                    }
                }
            }

            Console.WriteLine("CSV Files Merged Successfully. Output: merged_students.csv");
        }
    }
}
