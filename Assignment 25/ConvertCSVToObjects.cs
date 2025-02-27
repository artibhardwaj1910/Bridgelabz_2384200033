using System;
using System.Collections.Generic;
using System.IO;

namespace CSVDataHandlingAssignment
{
    class Student
    {
        public int Id;
        public string Name;
        public int Age;
        public double Marks;

        public Student(int id, string name, int age, double marks)
        {
            Id = id;
            Name = name;
            Age = age;
            Marks = marks;
        }

        public void PrintStudent()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}, Marks: {Marks}");
        }
    }

    class ConvertCSVToObjects
    {
        static void Main()
        {
            string filePath = "students.csv"; // CSV file path

            if (!File.Exists(filePath)) // Check if the file exists
            {
                Console.WriteLine("CSV file not found.");
                return;
            }

            List<Student> students = new List<Student>(); // List to store student objects
            string[] lines = File.ReadAllLines(filePath); // Read all lines

            for (int i = 0; i < lines.Length; i++) // Loop through each line
            {
                string[] values = lines[i].Split(','); // Split by comma

                if (values.Length < 4) // Ensure correct format
                {
                    Console.WriteLine($"Skipping invalid row {i + 1}: {lines[i]}");
                    continue;
                }

                int id = Convert.ToInt32(values[0]); // Convert ID
                string name = values[1]; // Get Name
                int age = Convert.ToInt32(values[2]); // Convert Age
                double marks = Convert.ToDouble(values[3]); // Convert Marks

                students.Add(new Student(id, name, age, marks)); // Add to list
            }

            Console.WriteLine("\nStudent List:");
            foreach (Student student in students) // Print all students
            {
                student.PrintStudent();
            }
        }
    }
}
