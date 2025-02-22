using System;
using System.IO;
class BufferedFileCopy
{
    static void Main()
    {
        string sourcePath = "largefile.dat";
        string destinationPathBuffered = "buffered_copy.dat";
        string destinationPathUnbuffered = "unbuffered_copy.dat";
        int bufferSize = 4096;

        try
        {
            // Buffered Stream Copy
            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationPathBuffered, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedStream = new BufferedStream(destinationStream, bufferSize))
            {
                byte[] buffer = new byte[bufferSize];
                int bytesRead;
                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bufferedStream.Write(buffer, 0, bytesRead);
                }
            }
            Console.WriteLine("Buffered Stream Copy Completed.");

            // Unbuffered Stream Copy
            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationPathUnbuffered, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[bufferSize];
                int bytesRead;
                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destinationStream.Write(buffer, 0, bytesRead);
                }
            }
            Console.WriteLine("Unbuffered Stream Copy Completed.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}