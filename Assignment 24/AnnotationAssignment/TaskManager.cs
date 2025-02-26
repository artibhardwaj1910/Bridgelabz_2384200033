using System;
using System.Reflection;
namespace Annotation{

// Step 1: Define the ImportantMethod attribute with an optional Level parameter
[AttributeUsage(AttributeTargets.Method)]
public class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    // Constructor with optional Level parameter (default: "HIGH")
    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

// Step 2: Define a class with methods that are marked as important
public class TaskManager
{
    [ImportantMethod("HIGH")]
    public void ProcessOrder()
    {
        Console.WriteLine("Processing order...");
    }

    [ImportantMethod("MEDIUM")]
    public void GenerateReport()
    {
        Console.WriteLine("Generating report...");
    }

    [ImportantMethod] // Default Level is "HIGH"
    public void HandlePayment()
    {
        Console.WriteLine("Handling payment...");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Step 3: Retrieve and print the annotated methods using Reflection
        MethodInfo[] methods = typeof(TaskManager).GetMethods();

        foreach (var method in methods)
        {
            // Check if the method has the ImportantMethod attribute
            var attribute = method.GetCustomAttribute<ImportantMethodAttribute>();

            if (attribute != null)
            {
                // Print the method name and the importance level
                Console.WriteLine($"Method: {method.Name}, Importance Level: {attribute.Level}");
            }
        }
    }}
}

