using System;
using System.Reflection;
namespace Reflection
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

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
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Get the type of the Student class
            Type type = typeof(Student);

            // Create an instance of the Student class dynamically
            object studentObj = Activator.CreateInstance(type, "John", 20);

            // Cast the object to Student type
            Student student = studentObj as Student;

            // Display the properties
            Console.WriteLine($"Student Name: {student.Name}, Age: {student.Age}");

            // Call the Study method
            student.Study();
        }
    }
}

