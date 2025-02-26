using System;
using System.Reflection;
namespace Reflection
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            // Accept class name as input
            Console.WriteLine("Enter the class name:");
            string className = Console.ReadLine();

            // Load the class type using Reflection
            Type type = Type.GetType(className);

            if (type != null)
            {
                // Get and display methods
                Console.WriteLine("\nMethods:");
                foreach (var method in type.GetMethods())
                {
                    Console.WriteLine(method.Name);
                }

                // Get and display fields
                Console.WriteLine("\nFields:");
                foreach (var field in type.GetFields())
                {
                    Console.WriteLine(field.Name);
                }

                // Get and display constructors
                Console.WriteLine("\nConstructors:");
                foreach (var constructor in type.GetConstructors())
                {
                    Console.WriteLine(constructor.ToString());
                }
            }
            else
            {
                Console.WriteLine("Class not found.");
            }
        }
    }

    // Example class to test
    public class Student
    {
        public string Name;
        public int Age;

        public Student() { }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Study()
        {
            Console.WriteLine(Name + " is studying.");
        }

        private void SecretMethod()
        {
            Console.WriteLine("This is a private method.");
        }
    }
}

