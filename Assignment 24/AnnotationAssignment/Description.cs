using System;
using System.Reflection;
namespace Annotation{

// Step 1: Define the BugReport attribute and allow it to be applied multiple times
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)] // Allow multiple applications on a method
public class BugReportAttribute : Attribute
{
    public string Description { get; }

    // Constructor to set the Description
    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

// Step 2: Define a class with methods that have multiple BugReport attributes applied
public class SoftwareModule
{
    [BugReport("Fix issue with user login.")]
    [BugReport("Resolve performance bottleneck in dashboard.")]
    public void ProcessData()
    {
        Console.WriteLine("Processing data...");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Step 3: Retrieve and print all BugReport attributes applied to the method

        // Get the MethodInfo for ProcessData method
        MethodInfo method = typeof(SoftwareModule).GetMethod("ProcessData");

        // Get all BugReport attributes applied to the method
        var bugReports = method.GetCustomAttributes<BugReportAttribute>();

        // Print each BugReport description
        foreach (var bugReport in bugReports)
        {
            Console.WriteLine($"Bug Report: {bugReport.Description}");
        }
    }}
}

