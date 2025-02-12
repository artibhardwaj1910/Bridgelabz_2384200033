using System;

namespace InheritenceAssignment
{
    // Base class Employee
    class Employee
    {
        protected string name;
        protected int id;
        protected double salary;

        // Constructor to initialize Employee attributes
        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        // Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Salary: ₹" + salary);
        }
    }

    // Subclass Manager inheriting from Employee
    class Manager : Employee
    {
        private int teamSize;

        // Constructor to initialize Manager attributes
        public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
        {
            this.teamSize = teamSize;
        }

        // Method to display Manager details
        public void DisplayManagerDetails()
        {
            DisplayDetails();
            Console.WriteLine("Team Size: " + teamSize);
        }
    }

    // Subclass Developer inheriting from Employee
    class Developer : Employee
    {
        private string programmingLanguage;

        // Constructor to initialize Developer attributes
        public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
        {
            this.programmingLanguage = programmingLanguage;
        }

        // Method to display Developer details
        public void DisplayDeveloperDetails()
        {
            DisplayDetails();
            Console.WriteLine("Programming Language: " + programmingLanguage);
        }
    }

    // Subclass Intern inheriting from Employee
    class Intern : Employee
    {
        private string internshipDuration;

        // Constructor to initialize Intern attributes
        public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary)
        {
            this.internshipDuration = internshipDuration;
        }

        // Method to display Intern details
        public void DisplayInternDetails()
        {
            DisplayDetails();
            Console.WriteLine("Internship Duration: " + internshipDuration);
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            // Creating objects of different subclasses
            Manager manager = new Manager("Amit", 101, 85000, 12);
            Developer developer = new Developer("Priya", 102, 70000, "Java");
            Intern intern = new Intern("Rahul", 103, 15000, "3 months");

            // Displaying details of each employee
            Console.WriteLine("Manager Details:");
            manager.DisplayManagerDetails();
            Console.WriteLine();

            Console.WriteLine("Developer Details:");
            developer.DisplayDeveloperDetails();
            Console.WriteLine();

            Console.WriteLine("Intern Details:");
            intern.DisplayInternDetails();
        }
    }
}
