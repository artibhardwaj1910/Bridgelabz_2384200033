using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace CSVDataHandlingAssignment
{
    class JsonCsvConverter
    {
        static void Main()
        {
            string jsonFile = "students.json";
            string csvFile = "students.csv";

            // Convert JSON to CSV
            ConvertJsonToCsv(jsonFile, csvFile);

            // Convert CSV to JSON
            ConvertCsvToJson(csvFile, "converted_students.json");
        }

        static void ConvertJsonToCsv(string jsonFile, string csvFile)
        {
            if (!File.Exists(jsonFile))
            {
                Console.WriteLine("JSON file not found.");
                return;
            }

            string jsonData = File.ReadAllText(jsonFile);
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonData);

            using (StreamWriter writer = new StreamWriter(csvFile))
            {
                writer.WriteLine("ID,Name,Age,Marks"); // CSV header
                foreach (var student in students)
                {
                    writer.WriteLine($"{student.ID},{student.Name},{student.Age},{student.Marks}");
                }
            }

            Console.WriteLine($"JSON converted to CSV: {csvFile}");
        }

        static void ConvertCsvToJson(string csvFile, string jsonFile)
        {
            if (!File.Exists(csvFile))
            {
                Console.WriteLine("CSV file not found.");
                return;
            }

            List<Student> students = new List<Student>();
            using (StreamReader reader = new StreamReader(csvFile))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false; // Skip the header row
                        continue;
                    }

                    string[] values = line.Split(',');
                    if (values.Length == 4)
                    {
                        students.Add(new Student
                        {
                            ID = values[0],
                            Name = values[1],
                            Age = values[2],
                            Marks = values[3]
                        });
                    }
                }
            }

            string jsonData = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(jsonFile, jsonData);

            Console.WriteLine($"CSV converted to JSON: {jsonFile}");
        }
    }

    class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Marks { get; set; }
    }
}
