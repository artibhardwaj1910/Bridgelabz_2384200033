using System;
using System.Reflection;
namespace Reflection
{
    public class Calculator
    {
        private int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of the Calculator class
            Calculator calculator = new Calculator();

            // Get the type of the Calculator class
            Type type = typeof(Calculator);

            // Get the private method "Multiply"
            MethodInfo methodInfo = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

            if (methodInfo != null)
            {
                // Invoke the private method and display the result
                object result = methodInfo.Invoke(calculator, new object[] { 5, 6 });
                Console.WriteLine("Multiplication Result: " + result);
            }
        }
    }
}

