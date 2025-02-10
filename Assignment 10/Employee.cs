using System;
namespace KeywordAssignment
{
    class Employee
    {
        private static string companyName = "Tech Solutions"; 
        private static int totalEmployees = 0; 
        private readonly int id; 
        private string name;
        private string designation;

        public Employee(string name, int id, string designation)
        {
            this.name = name;
            this.id = id;
            this.designation = designation;
            totalEmployees++; 
        }

        public static void DisplayTotalEmployees()
        {
            Console.WriteLine($"Total Employees: {totalEmployees}");
        }

        public void DisplayEmployeeDetails()
        {
            if (this is Employee) 
            {
                Console.WriteLine($"Company: {companyName}");
                Console.WriteLine($"Employee Name: {name}");
                Console.WriteLine($"Employee ID: {id}");
                Console.WriteLine($"Designation: {designation}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee("Michael Smith", 101, "Software Engineer");
            emp1.DisplayEmployeeDetails();
            Employee.DisplayTotalEmployees();
        }
    }
}

