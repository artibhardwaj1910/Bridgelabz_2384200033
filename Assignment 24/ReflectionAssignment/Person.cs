using System;
using System.Reflection;
namespace Reflection
{
    public class Person
    {
        private int age;

        public Person(int age)
        {
            this.age = age;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of the Person class
            Person person = new Person(25);

            // Get the type of the Person class
            Type type = typeof(Person);

            // Get the private field "age"
            FieldInfo fieldInfo = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

            if (fieldInfo != null)
            {
                // Get the value of the private field
                object fieldValue = fieldInfo.GetValue(person);
                Console.WriteLine("Initial Age: " + fieldValue);

                // Modify the private field
                fieldInfo.SetValue(person, 30);

                // Get the updated value of the private field
                fieldValue = fieldInfo.GetValue(person);
                Console.WriteLine("Updated Age: " + fieldValue);
            }
        }
    }
}

