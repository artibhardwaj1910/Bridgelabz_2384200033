using System;
using System.Reflection;
namespace Annotation{

// Custom Attribute to Restrict Access Based on Role
[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
public class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

// Simulate a User class with roles
public class User
{
    public string Role { get; set; }

    public User(string role)
    {
        Role = role;
    }
}

// Class that contains methods with restricted access
public class Resource
{
    // Method restricted to ADMIN role
    [RoleAllowed("ADMIN")]
    public void AccessAdminResource()
    {
        Console.WriteLine("Access Granted: Admin Resource.");
    }

    // Method restricted to USER role
    [RoleAllowed("USER")]
    public void AccessUserResource()
    {
        Console.WriteLine("Access Granted: User Resource.");
    }
}

// Role-Based Access Control Logic
public class AccessControl
{
    public static void InvokeMethod(object obj, string methodName, User user)
    {
        // Get the method using reflection
        MethodInfo method = obj.GetType().GetMethod(methodName);
        
        // Check if the RoleAllowed attribute is applied
        var roleAllowedAttribute = method.GetCustomAttribute<RoleAllowedAttribute>();

        if (roleAllowedAttribute != null)
        {
            // If the user's role matches the required role, invoke the method
            if (roleAllowedAttribute.Role == user.Role)
            {
                method.Invoke(obj, null);
            }
            else
            {
                Console.WriteLine("Access Denied!");
            }
        }
        else
        {
            // If no RoleAllowed attribute is set, allow access by default
            method.Invoke(obj, null);
        }
    }
}

class Program
{
    static void Main()
    {
        // Simulating users with different roles
        User adminUser = new User("ADMIN");
        User regularUser = new User("USER");

        // Create an instance of the Resource class
        Resource resource = new Resource();

        // Test with ADMIN role
        Console.WriteLine("Admin User attempting to access Admin resource:");
        AccessControl.InvokeMethod(resource, "AccessAdminResource", adminUser); // Should succeed

        Console.WriteLine("\nAdmin User attempting to access User resource:");
        AccessControl.InvokeMethod(resource, "AccessUserResource", adminUser); // Should fail

        // Test with USER role
        Console.WriteLine("\nRegular User attempting to access Admin resource:");
        AccessControl.InvokeMethod(resource, "AccessAdminResource", regularUser); // Should fail

        Console.WriteLine("\nRegular User attempting to access User resource:");
        AccessControl.InvokeMethod(resource, "AccessUserResource", regularUser); // Should succeed
    }
}}
