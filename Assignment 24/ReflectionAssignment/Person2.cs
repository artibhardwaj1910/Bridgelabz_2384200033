using System;
using System.Collections.Generic;
using System.Reflection;
namespace Reflection
{
    public class Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Program
    {
        public static T ToObject<T>(Type clazz, Dictionary<string, object> properties) where T : new()
        {
            // Create an instance of the specified class
            T obj = new T();
            
            // Get the properties of the class
            PropertyInfo[] propertiesInfo = clazz.GetProperties();

            foreach (var property in propertiesInfo)
            {
                if (properties.ContainsKey(property.Name))
                {
                    property.SetValue(obj, properties[property.Name]);
                }
            }

            return obj;
        }

        public static void Main(string[] args)
        {
            // Example usage
            var properties = new Dictionary<string, object>
            {
                { "Name", "John Doe" },
                { "Age", 30 }
            };

            Person person = ToObject<Person>(typeof(Person), properties);
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}

