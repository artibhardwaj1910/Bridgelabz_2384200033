using System;
using System.IO;
class ReadFile
{
    static void Main()
    {
        string filePath = "data.txt";
        
        try
        {
            // Read the file content
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Contents:\n" + content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while reading the file: " + ex.Message);
        }
    }
}

