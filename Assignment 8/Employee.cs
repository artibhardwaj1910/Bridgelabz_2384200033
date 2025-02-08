using System;
namespace ClassObjectLevel01
{
    public class Employee
    {
        // fields 
        private string name;
        private int id;
        private double salary;

        // Constructor to initialize
        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        // Method to display
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Name: {name}");
            Console.WriteLine($"Employee ID: {id}");
            Console.WriteLine($"Employee Salary: ${salary}");
        }
    }

    // Main class 
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating an Employee object
            Employee employee1 = new Employee("Ankit", 22, 50000.00);

            // Displaying employee details
            employee1.DisplayDetails();
        }
    }
}

