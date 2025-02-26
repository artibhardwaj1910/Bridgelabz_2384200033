using System;
using System.Reflection;
namespace Reflection
{
    public class Configuration
    {
        private static string API_KEY = "Initial_API_Key";

        public static void DisplayAPIKey()
        {
            Console.WriteLine("Current API Key: " + API_KEY);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Get the type of the Configuration class
            Type type = typeof(Configuration);

            // Get the private static field "API_KEY"
            FieldInfo fieldInfo = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

            if (fieldInfo != null)
            {
                // Display the initial value of the static field
                object fieldValue = fieldInfo.GetValue(null);
                Console.WriteLine("Initial API Key: " + fieldValue);

                // Modify the value of the static field
                fieldInfo.SetValue(null, "Updated_API_Key");

                // Display the updated value
                fieldValue = fieldInfo.GetValue(null);
                Console.WriteLine("Updated API Key: " + fieldValue);
            }
            else
            {
                Console.WriteLine("Field not found.");
            }

            // Call the method to display the static field using the class method
            Configuration.DisplayAPIKey();
        }
    }
}

