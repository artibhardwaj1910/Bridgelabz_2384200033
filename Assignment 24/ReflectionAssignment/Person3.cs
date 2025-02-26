using System;
using System.Reflection;
using System.Text;
namespace Reflection
{
    public class Person3
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
    }

    public class Program
    {
        public static string ToJson(object obj)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.Append("{");

            // Get the properties of the object
            PropertyInfo[] properties = obj.GetType().GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                var property = properties[i];
                var value = property.GetValue(obj);
                jsonBuilder.Append($"\"{property.Name}\": \"{value}\"");

                if (i < properties.Length - 1)
                {
                    jsonBuilder.Append(", ");
                }
            }

            jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }

        public static void Main(string[] args)
        {
            Person person = new Person { Name = "Alice", Age = 25, IsActive = true };
            string json = ToJson(person);
            Console.WriteLine(json);
        }
    }
}

