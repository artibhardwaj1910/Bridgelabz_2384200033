using System;
using System.Diagnostics;
using System.IO;
using System.Text;
namespace TimeNSpaceAssignment
{
    class LargeFileReading
    {
        // Generate a large test file
        static void GenerateTestFile(string filePath, long fileSizeInMB)
        {
            byte[] data = new byte[1024 * 1024]; // 1MB Buffer
            Random random = new Random();

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                for (int i = 0; i < fileSizeInMB; i++)
                {
                    random.NextBytes(data); // Fill with random bytes
                    fs.Write(data, 0, data.Length);
                }
            }
        }

        // Read file using StreamReader (Character-based)
        static void ReadUsingStreamReader(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
            {
                while (sr.ReadLine() != null) { } // Read line by line
            }
        }

        // Read file using FileStream (Byte-based)
        static void ReadUsingFileStream(string filePath)
        {
            byte[] buffer = new byte[4096]; // 4KB Buffer

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                while (fs.Read(buffer, 0, buffer.Length) > 0) { } // Read chunks
            }
        }

        static void Main()
        {
            string filePath = "test_large_file.dat";
            long[] fileSizes = { 1, 100, 500 }; // MB

            foreach (long fileSize in fileSizes)
            {
                Console.WriteLine($"File Size: {fileSize}MB");

                // Generate test file
                GenerateTestFile(filePath, fileSize);

                // StreamReader Timing
                Stopwatch stopwatch = Stopwatch.StartNew();
                ReadUsingStreamReader(filePath);
                stopwatch.Stop();
                Console.WriteLine($"StreamReader (O(N)) | {fileSize}MB | Time={stopwatch.ElapsedMilliseconds} ms");

                // FileStream Timing
                stopwatch.Restart();
                ReadUsingFileStream(filePath);
                stopwatch.Stop();
                Console.WriteLine($"FileStream (O(N)) | {fileSize}MB | Time={stopwatch.ElapsedMilliseconds} ms\n");
            }
        }
    }
}
