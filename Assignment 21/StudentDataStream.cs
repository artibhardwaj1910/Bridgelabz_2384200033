using System;
using System.IO;
class StudentDataStream
{
    static void Main()
    {
        string filePath = "students.dat";

        try
        {
            // Writing student data to binary file
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                writer.Write(1); // Roll Number
                writer.Write("Alice"); // Name
                writer.Write(3.8); // GPA

                writer.Write(2);
                writer.Write("Bob");
                writer.Write(3.5);
            }
            Console.WriteLine("Student data saved successfully.");

            // Reading student data from binary file
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                while (fileStream.Position < fileStream.Length)
                {
                    int rollNumber = reader.ReadInt32();
                    string name = reader.ReadString();
                    double gpa = reader.ReadDouble();

                    Console.WriteLine($"Roll No: {rollNumber}, Name: {name}, GPA: {gpa}");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}