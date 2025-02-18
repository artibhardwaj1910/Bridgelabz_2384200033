using System;
using System.Text;
using System.Diagnostics;
namespace StringBuilderAssignment
{
    class ComparePerformance
    {
        static void Main()
        {
            // Define the number of iterations for testing
            int iterations = 100000;

            // Measuring time for string concatenation
            Stopwatch stopwatchString = new Stopwatch();
            stopwatchString.Start();

            string normalString = "";
            for (int i = 0; i < iterations; i++)
            {
                normalString += "A"; // Concatenation using regular string
            }

            stopwatchString.Stop();
            Console.WriteLine("Time taken using string concatenation: " + stopwatchString.ElapsedMilliseconds + " ms");

            // Measuring time for StringBuilder concatenation
            Stopwatch stopwatchStringBuilder = new Stopwatch();
            stopwatchStringBuilder.Start();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                sb.Append("A"); // Efficient concatenation using StringBuilder
            }

            stopwatchStringBuilder.Stop();
            Console.WriteLine("Time taken using StringBuilder: " + stopwatchStringBuilder.ElapsedMilliseconds + " ms");
        }
    }
}

