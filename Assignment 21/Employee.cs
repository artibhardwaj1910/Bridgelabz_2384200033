using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

[Serializable]
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class EmployeeSerialization
{
    static void Main()
    {
        string filePath = "employees.json";

        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 50000 },
            new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 70000 },
            new Employee { Id = 3, Name = "Charlie", Department = "Finance", Salary = 65000 }
        };

        try
        {
            // Serialize employee list to file
            string jsonString = JsonSerializer.Serialize(employees);
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Employee data saved successfully.");

            // Deserialize employee list from file
            string readJson = File.ReadAllText(filePath);
            List<Employee> deserializedEmployees = JsonSerializer.Deserialize<List<Employee>>(readJson);

            Console.WriteLine("Deserialized Employee List:");
            foreach (var emp in deserializedEmployees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}