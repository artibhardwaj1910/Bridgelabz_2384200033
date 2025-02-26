using System;
using System.Diagnostics;
using System.Reflection;
namespace Reflection
{
    public class Calculator2
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    public class Program
    {
        public static void MeasureExecutionTime(object obj, string methodName, object[] parameters)
        {
            // Get the type of the object
            Type type = obj.GetType();

            // Get the method info for the specified method
            MethodInfo methodInfo = type.GetMethod(methodName);

            // Start measuring time
            var stopwatch = Stopwatch.StartNew();

            // Invoke the method
            methodInfo.Invoke(obj, parameters);

            // Stop measuring time
            stopwatch.Stop();

            // Display the execution time
            Console.WriteLine($"Execution Time for {methodName}: {stopwatch.ElapsedMilliseconds} ms");
        }

        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            // Measure execution time for Add method
            MeasureExecutionTime(calculator, "Add", new object[] { 5, 6 });

            // Measure execution time for Multiply method
            MeasureExecutionTime(calculator, "Multiply", new object[] { 5, 6 });
        }
}}

