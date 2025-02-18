using System;
using System.IO;
namespace FileHandlingAssignment
{
    class WriteUserInputToFile
    {
        static void Main()
        {
            // Specify the file path
            string filePath = "C:\Users\Ankit Singh\OneDrive\Desktop"; 
            // Ask the user for input
            Console.WriteLine("Enter text to save in the file (type 'exit' to stop):");

            // Open StreamWriter to write to the file
            StreamWriter writer = new StreamWriter(filePath);

            string input;
            while ((input = Console.ReadLine()) != "exit") // Stop when user types 'exit'
            {
                writer.WriteLine(input); // Write input to the file
            }

            // Close the writer
            writer.Close();

            Console.WriteLine($"Your input has been saved to {filePath}");
        }
    }
}

