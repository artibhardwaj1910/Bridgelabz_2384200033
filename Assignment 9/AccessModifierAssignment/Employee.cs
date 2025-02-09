using System;
namespace AccessModifierAssignment{
    // Base class Employee
    class Employee{
        // Public, protected, and private members
        public string employeeID;
        protected string department;
        private double salary;

        // Constructor to initialize values
        public Employee(string employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }

        // Getter method for salary
        public double GetSalary()
        {
            return salary;
        }

        // Setter method for salary
        public void SetSalary(double salary)
        {
            if (salary >= 0)
            {
                this.salary = salary;
            }
            else
            {
                Console.WriteLine("Invalid salary amount.");
            }
        }
    }

    // Derived class Manager demonstrating access to employeeID and department
    class Manager : Employee
    {
        // Constructor to initialize values, calling base class constructor
        public Manager(string employeeID, string department, double salary)
            : base(employeeID, department, salary)
        {
        }

        // Method to display employee ID and department
        public void DisplayManagerInfo()
        {
            Console.WriteLine("Manager Employee ID: " + employeeID);
            Console.WriteLine("Manager Department: " + department);
        }
    }

}
