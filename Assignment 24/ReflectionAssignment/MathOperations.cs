using System;
using System.Reflection;
namespace Reflection
{
    public class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Ask user for input
            Console.WriteLine("Enter the method you want to call (Add, Subtract, Multiply):");
            string methodName = Console.ReadLine();

            // Ask for two integers
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            // Get the type of MathOperations
            Type type = typeof(MathOperations);
            
            // Create an instance of MathOperations
            object obj = Activator.CreateInstance(type);

            // Get the method info dynamically based on user input
            MethodInfo methodInfo = type.GetMethod(methodName);

            if (methodInfo != null)
            {
                // Dynamically invoke the method and get the result
                object result = methodInfo.Invoke(obj, new object[] { num1, num2 });
                Console.WriteLine($"Result of {methodName}: {result}");
            }
            else
            {
                Console.WriteLine("Method not found.");
            }
        }
    }
}

using System;
using System.Reflection;
namespace Reflection
{
// Define custom attribute
[AttributeUsage(AttributeTargets.Class)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }
    
    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

namespace ReflectionExample
{
    [Author("John Doe")]
    public class SampleClass
    {
        public void DisplayMessage()
        {
            Console.WriteLine("This is a sample class.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Get the type of the SampleClass
            Type type = typeof(SampleClass);

            // Retrieve the Author attribute applied to the class
            AuthorAttribute authorAttribute = (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

            if (authorAttribute != null)
            {
                Console.WriteLine($"Author of {type.Name}: {authorAttribute.Name}");
            }
            else
            {
                Console.WriteLine("Author attribute not found.");
            }
        }
    }
}}

