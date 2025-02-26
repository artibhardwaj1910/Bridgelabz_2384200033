using System;
using System.Reflection;
namespace Annotation{

// Step 1: Define the custom attribute TaskInfo
[AttributeUsage(AttributeTargets.Method)]
public class TaskInfoAttribute : Attribute
{
    public string Priority { get; set; }
    public string AssignedTo { get; set; }

    // Constructor to set values
    public TaskInfoAttribute(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

// Step 2: Define a class TaskManager and apply the TaskInfo attribute
public class TaskManager
{
    [TaskInfo("High", "Alice")]
    public void Task1()
    {
        Console.WriteLine("Task 1 is in progress.");
    }

    [TaskInfo("Medium", "Bob")]
    public void Task2()
    {
        Console.WriteLine("Task 2 is in progress.");
    }

    [TaskInfo("Low", "Charlie")]
    public void Task3()
    {
        Console.WriteLine("Task 3 is in progress.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Step 3: Retrieve the attribute details using Reflection

        // Create an instance of TaskManager
        TaskManager taskManager = new TaskManager();

        // Get the methods from TaskManager class
        MethodInfo[] methods = typeof(TaskManager).GetMethods();

        foreach (var method in methods)
        {
            // Check if the method has the TaskInfo attribute
            var attribute = method.GetCustomAttribute<TaskInfoAttribute>();

            if (attribute != null)
            {
                // Display the method name and the attribute values
                Console.WriteLine($"Method: {method.Name}, Priority: {attribute.Priority}, Assigned To: {attribute.AssignedTo}");
            }
        }}
    }
}
