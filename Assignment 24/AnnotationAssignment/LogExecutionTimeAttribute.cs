using System;
using System.Reflection;
namespace Annotation{

// Step 1: Define the LogExecutionTime attribute
[AttributeUsage(AttributeTargets.Method)]
public class LogExecutionTimeAttribute : Attribute
{
    // This attribute doesn't need fields for this task, it's just for marking methods.
}

// Step 2: Define the class with methods that need execution time logging
public class PerformanceTest
{
    [LogExecutionTime]
    public void QuickMethod()
    {
        // Simulate quick execution
        for (int i = 0; i < 10000; i++)
        {
            // Do some work
        }
    }

    [LogExecutionTime]
    public void SlowMethod()
    {
        // Simulate slow execution
        for (int i = 0; i < 10000000; i++)
        {
            // Do some work
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of the PerformanceTest class
        PerformanceTest test = new PerformanceTest();

        // Get all methods from the PerformanceTest class
        MethodInfo[] methods = typeof(PerformanceTest).GetMethods();

        // Iterate through all methods and execute the ones that have the LogExecutionTime attribute
        foreach (var method in methods)
        {
            // Check if the method has the LogExecutionTime attribute
            var attribute = method.GetCustomAttribute<LogExecutionTimeAttribute>();
            
            if (attribute != null)
            {
                // Log the execution time using Stopwatch
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                // Invoke the method
                method.Invoke(test, null);

                stopwatch.Stop();
                Console.WriteLine($"{method.Name} executed in {stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }}
}
