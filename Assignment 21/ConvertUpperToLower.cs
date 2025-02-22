using System;
using System.IO;
using System.Text;

class ConvertUpperToLower
{
    static void Main()
    {
        string sourceFilePath = "source.txt";
        string destinationFilePath = "destination.txt";

        try
        {
            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (BufferedStream bufferedSource = new BufferedStream(sourceStream))
            using (StreamReader reader = new StreamReader(bufferedSource, Encoding.UTF8))
            using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedDestination = new BufferedStream(destinationStream))
            using (StreamWriter writer = new StreamWriter(bufferedDestination, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }

            Console.WriteLine("File successfully converted to lowercase.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}