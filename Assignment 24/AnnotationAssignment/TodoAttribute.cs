using System;
using System.Reflection;
namespace Annotation{

// Step 1: Define the Todo attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    // Constructor to set the fields, with Priority defaulting to "MEDIUM"
    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

// Step 2: Define a class with methods that have Todo attributes applied
public class ProjectTasks
{
    [Todo("Implement login feature", "Alice", "HIGH")]
    public void LoginFeature()
    {
        Console.WriteLine("Login feature is pending.");
    }

    [Todo("Refactor codebase", "Bob", "LOW")]
    public void RefactorCodebase()
    {
        Console.WriteLine("Codebase refactoring is pending.");
    }

    [Todo("Add unit tests for checkout", "Charlie")]
    public void AddUnitTests()
    {
        Console.WriteLine("Unit tests for checkout are pending.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Step 3: Retrieve and print all pending tasks using Reflection

        // Get the methods in the ProjectTasks class
        MethodInfo[] methods = typeof(ProjectTasks).GetMethods();

        foreach (var method in methods)
        {
            // Retrieve all Todo attributes applied to each method
            var todoAttributes = method.GetCustomAttributes<TodoAttribute>();

            foreach (var todo in todoAttributes)
            {
                // Print the task details
                Console.WriteLine($"Task: {todo.Task}, Assigned To: {todo.AssignedTo}, Priority: {todo.Priority}");
            }
        }
    }
}}
