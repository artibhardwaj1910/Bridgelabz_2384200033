using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace Annotation{

// Custom Attribute to Mark Fields for JSON Serialization
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = false)]
public class JsonFieldAttribute : Attribute
{
    public string Name { get; }

    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}

// Class representing a User with fields marked for JSON serialization
public class User
{
    [JsonField("user_name")]
    public string UserName { get; set; }

    [JsonField("user_email")]
    public string Email { get; set; }

    [JsonField("user_age")]
    public int Age { get; set; }
}

// Serialization Logic: Converts an Object to JSON String
public static class JsonSerializer
{
    public static string Serialize(object obj)
    {
        var jsonFields = new Dictionary<string, object>();

        // Get all properties and fields from the object
        var properties = obj.GetType().GetProperties();
        var fields = obj.GetType().GetFields();

        // Combine properties and fields for serialization
        var members = properties.Cast<MemberInfo>().Concat(fields.Cast<MemberInfo>());

        foreach (var member in members)
        {
            var jsonFieldAttr = member.GetCustomAttribute<JsonFieldAttribute>();
            if (jsonFieldAttr != null)
            {
                // Get the custom name from the JsonFieldAttribute
                string jsonKey = jsonFieldAttr.Name;
                object value = null;

                // If it's a property, get its value
                if (member is PropertyInfo property)
                {
                    value = property.GetValue(obj);
                }
                // If it's a field, get its value
                else if (member is FieldInfo field)
                {
                    value = field.GetValue(obj);
                }

                // Add the field name and its value to the dictionary
                jsonFields[jsonKey] = value;
            }
        }

        // Build the JSON string from the dictionary
        return BuildJsonString(jsonFields);
    }

    private static string BuildJsonString(Dictionary<string, object> fields)
    {
        var jsonParts = new List<string>();
        foreach (var field in fields)
        {
            var value = field.Value != null ? $"\"{field.Value}\"" : "null";
            jsonParts.Add($"\"{field.Key}\": {value}");
        }
        return "{" + string.Join(", ", jsonParts) + "}";
    }
}

class Program
{
    static void Main()
    {
        // Create a new User object
        var user = new User
        {
            UserName = "john_doe",
            Email = "john.doe@example.com",
            Age = 30
        };

        // Serialize the user object to JSON
        string jsonString = JsonSerializer.Serialize(user);

        // Output the JSON string
        Console.WriteLine(jsonString);
    }
}}

