using System;
using System.Reflection;
namespace Annotation{

// Step 1: Define the MaxLength attribute
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class MaxLengthAttribute : Attribute
{
    public int Value { get; }

    public MaxLengthAttribute(int value)
    {
        Value = value;
    }
}

// Step 2: Define the User class with a Username field that is validated with MaxLength
public class User
{
    [MaxLength(10)]  // Applying the MaxLength attribute to the Username field
    public string Username { get; }

    public User(string username)
    {
        // Step 3: Validate the Username length in the constructor
        var usernameField = typeof(User).GetField("Username");
        var maxLengthAttr = (MaxLengthAttribute)Attribute.GetCustomAttribute(usernameField, typeof(MaxLengthAttribute));

        if (maxLengthAttr != null && username.Length > maxLengthAttr.Value)
        {
            throw new ArgumentException($"Username cannot exceed {maxLengthAttr.Value} characters.");
        }

        Username = username;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            // Test with a valid username
            User user1 = new User("JohnDoe");
            Console.WriteLine($"User1 created: {user1.Username}");

            // Test with an invalid username (too long)
            User user2 = new User("ThisIsTooLongUsername");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}}
