using System;
using System.IO;
class FileReadWrite
{
    static void Main()
    {
        string sourcePath = "source.txt"; 
        string destinationPath = "destination.txt";

        try
        {
            // Check if the source file exists
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            // Open FileStream for reading
            using (FileStream fsRead = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fsRead))
            {
                string content = reader.ReadToEnd();

                // Open FileStream for writing
                using (FileStream fsWrite = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fsWrite))
                {
                    writer.Write(content);
                }
            }
            
            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}