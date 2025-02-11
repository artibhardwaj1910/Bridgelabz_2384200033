using System;
using System.Collections.Generic;

namespace ObjectModelAssignment
{
    class Faculty
    {
        private string facultyName;
        private string specialization;

        // Constructor to initialize faculty details
        public Faculty(string facultyName, string specialization)
        {
            this.facultyName = facultyName;
            this.specialization = specialization;
        }

        // Method to display faculty details
        public void DisplayFaculty()
        {
            Console.WriteLine($"Faculty: {facultyName}, Specialization: {specialization}");
        }
    }

    // Department class representing a division in the university
    class Department
    {
        private string departmentName;

        // Constructor to initialize department name
        public Department(string departmentName)
        {
            this.departmentName = departmentName;
        }

        // Method to display department details
        public void DisplayDepartment()
        {
            Console.WriteLine($"Department: {departmentName}");
        }
    }

    // University class representing an educational institution
    class University
    {
        private string universityName;
        private List<Department> departments; // Composition: University owns departments
        private List<Faculty> faculties; // Aggregation: University has faculties

        // Constructor to initialize university name, departments, and faculties
        public University(string universityName)
        {
            this.universityName = universityName;
            this.departments = new List<Department>();
            this.faculties = new List<Faculty>();
        }

        // Method to add a department (Composition)
        public void AddDepartment(string departmentName)
        {
            Department newDepartment = new Department(departmentName);
            departments.Add(newDepartment);
        }

        // Method to add a faculty member (Aggregation)
        public void AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
        }

        // Method to display university details
        public void DisplayUniversity()
        {
            Console.WriteLine($"University: {universityName}");
            
            Console.WriteLine("\nDepartments:");
            foreach (Department department in departments)
            {
                department.DisplayDepartment();
            }

            Console.WriteLine("\nFaculty Members:");
            foreach (Faculty faculty in faculties)
            {
                faculty.DisplayFaculty();
            }
            Console.WriteLine();
        }

        // Destructor to delete university and all its departments
        ~University()
        {
            Console.WriteLine($"University {universityName} and all its departments are being deleted.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating a university object
            University university = new University("Global Tech University");

            // Adding departments to the university (Composition)
            university.AddDepartment("Computer Science");
            university.AddDepartment("Physics");
            university.AddDepartment("Mathematics");

            // Creating faculty members (Aggregation - they exist independently)
            Faculty faculty1 = new Faculty("Dr. Smith", "Artificial Intelligence");
            Faculty faculty2 = new Faculty("Dr. Johnson", "Quantum Mechanics");

            // Adding faculty members to the university
            university.AddFaculty(faculty1);
            university.AddFaculty(faculty2);

            // Displaying university details
            university.DisplayUniversity();

            // University object goes out of scope, triggering destructor
        }
    }
}
