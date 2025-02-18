using System;
using System.IO;

namespace FileHandlingAssignment
{
    class ReadFile
    {
        static void Main()
        {
            // Specify the file path
            string filePath = "C:\Users\Ankit Singh\OneDrive\Desktop";

            // Open the file and read it line by line
            StreamReader reader = new StreamReader(filePath);
            
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line); // Print each line
            }
            
            // Close the reader
            reader.Close();
        }
    }
}

