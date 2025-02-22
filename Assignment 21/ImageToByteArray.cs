using System;
using System.IO;
class ImageToByteArray
{
    static void Main()
    {
        string sourceImagePath = "source.jpg";
        string destinationImagePath = "copy.jpg";

        try
        {
            // Convert image to byte array
            byte[] imageBytes = File.ReadAllBytes(sourceImagePath);

            // Write byte array back to image file
            File.WriteAllBytes(destinationImagePath, imageBytes);

            Console.WriteLine("Image successfully copied.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}