using System;
using System.Collections.Generic;

namespace ObjectModelAssignment
{
    class Employee
    {
        private string name;
        private string position;

        // Constructor 
        public Employee(string name, string position)
        {
            this.name = name;
            this.position = position;
        }

        // Method to display employee details
        public void DisplayEmployee()
        {
            Console.WriteLine($"Employee: {name}, Position: {position}");
        }
    }

    // Department class representing a department in a company
    class Department
    {
        private string departmentName;
        private List<Employee> employees; // Composition: Department has employees

        // Constructor to initialize department name and employee list
        public Department(string departmentName)
        {
            this.departmentName = departmentName;
            this.employees = new List<Employee>();
        }

        // Method to add an employee to the department
        public void AddEmployee(string name, string position)
        {
            Employee newEmployee = new Employee(name, position);
            employees.Add(newEmployee);
        }

        // Method to display department details
        public void DisplayDepartment()
        {
            Console.WriteLine($"Department: {departmentName}");
            foreach (Employee employee in employees)
            {
                employee.DisplayEmployee();
            }
            Console.WriteLine();
        }
    }

    // Company class representing an organization
    class Company
    {
        private string companyName;
        private List<Department> departments; // Composition: Company owns departments

        // Constructor to initialize company name and department list
        public Company(string companyName)
        {
            this.companyName = companyName;
            this.departments = new List<Department>();
        }

        // Method to add a department to the company
        public void AddDepartment(string departmentName)
        {
            Department newDepartment = new Department(departmentName);
            departments.Add(newDepartment);
        }

        // Method to get the department by name
        public Department GetDepartment(string departmentName)
        {
            foreach (Department department in departments)
            {
                if (departmentName == departmentName)
                {
                    return department;
                }
            }
            return null;
        }

        // Method to display company details
        public void DisplayCompany()
        {
            Console.WriteLine($"Company: {companyName}");
            foreach (Department department in departments)
            {
                department.DisplayDepartment();
            }
        }

        // Destructor to ensure all departments and employees are deleted with the company
        ~Company()
        {
            Console.WriteLine($"Company {companyName} and all its departments and employees are being deleted.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating a company object
            Company company = new Company("Tech Solutions");

            // Adding departments
            company.AddDepartment("IT");
            company.AddDepartment("HR");

            // Getting departments and adding employees
            Department itDepartment = company.GetDepartment("IT");
            if (itDepartment != null)
            {
                itDepartment.AddEmployee("Alice", "Software Engineer");
                itDepartment.AddEmployee("Bob", "System Administrator");
            }

            Department hrDepartment = company.GetDepartment("HR");
            if (hrDepartment != null)
            {
                hrDepartment.AddEmployee("Charlie", "HR Manager");
                hrDepartment.AddEmployee("David", "Recruiter");
            }

            // Displaying company details
            company.DisplayCompany();

            // Company object goes out of scope, triggering destructor
        }
    }
}
