using System;
using System.Diagnostics;
using System.Text;
namespace TimeNSpaceAssignment
{
    class StringConcatenationPerformance
    {
        // Method to measure string concatenation (O(N²))
        static void ConcatenateUsingString(int operations)
        {
            string result = "";
            for (int i = 0; i < operations; i++)
            {
                result += "a"; // Inefficient, creates a new string each time
            }
        }

        // Method to measure StringBuilder concatenation (O(N))
        static void ConcatenateUsingStringBuilder(int operations)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < operations; i++)
            {
                sb.Append("a"); // Efficient, modifies the same object
            }
        }

        static void Main()
        {
            int[] sizes = { 1000, 10000, 1000000 };

            foreach (int size in sizes)
            {
                Console.WriteLine($"Operations Count: {size}");

                // String Concatenation Timing (Inefficient)
                Stopwatch stopwatch = Stopwatch.StartNew();
                ConcatenateUsingString(size);
                stopwatch.Stop();
                Console.WriteLine($"String (O(N²)) | N={size} | Time={stopwatch.ElapsedMilliseconds} ms");

                // StringBuilder Concatenation Timing (Efficient)
                stopwatch.Restart();
                ConcatenateUsingStringBuilder(size);
                stopwatch.Stop();
                Console.WriteLine($"StringBuilder (O(N)) | N={size} | Time={stopwatch.ElapsedMilliseconds} ms\n");
            }
        }
    }
}
