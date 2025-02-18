using System;
using System.IO;
using System.Text;

namespace FileHandlingAssignment
{
    class ByteToCharacterStream
    {
        static void Main()
        {
            // Specify the file path
            string filePath = "C:\Users\Ankit Singh\OneDrive\Desktop";

            // Open the binary file as a byte stream
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            // Convert byte stream to character stream using StreamReader
            StreamReader reader = new StreamReader(fileStream, Encoding.UTF8);

            // Read and display the file content
            string content = reader.ReadToEnd();
            Console.WriteLine("File Content:");
            Console.WriteLine(content);

            // Close the reader
            reader.Close();
        }
    }
}

