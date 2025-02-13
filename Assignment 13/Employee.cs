using System;
using System.Collections.Generic;

// Abstract class Employee
public abstract class Employee
{
    // Encapsulated fields
    private int employeeId;
    private string name;
    private double baseSalary;
    // Properties for encapsulated fields
    public int EmployeeId
    {
        get { return employeeId; }
        set { employeeId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double BaseSalary
    {
        get { return baseSalary; }
        set { baseSalary = value; }
    }

    // Constructor
    public Employee(int employeeId, string name, double baseSalary)
    {
        this.EmployeeId = employeeId;
        this.Name = name;
        this.BaseSalary = baseSalary;
    }

    // Abstract method
    public abstract double CalculateSalary();

    // Concrete method
    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Salary: {CalculateSalary():C}");
    }
}

// Interface for Department
public interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

// FullTimeEmployee class
public class FullTimeEmployee : Employee, IDepartment
{
    private string department;
    private double bonus;

    public FullTimeEmployee(int employeeId, string name, double baseSalary, double bonus)
        : base(employeeId, name, baseSalary)
    {
        this.bonus = bonus;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + bonus;
    }

    public void AssignDepartment(string department)
    {
        this.department = department;
    }

    public string GetDepartmentDetails()
    {
        return $"Employee {Name} is in {department} department.";
    }
}

// PartTimeEmployee class
public class PartTimeEmployee : Employee, IDepartment
{
    private string department;
    private double hourlyRate;
    private int hoursWorked;

    public PartTimeEmployee(int employeeId, string name, double hourlyRate, int hoursWorked)
        : base(employeeId, name, 0)
    {
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }

    public override double CalculateSalary()
    {
        return hourlyRate * hoursWorked;
    }

    public void AssignDepartment(string department)
    {
        this.department = department;
    }

    public string GetDepartmentDetails()
    {
        return $"Employee {Name} is in {department} department.";
    }
}

// Main Program
class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new FullTimeEmployee(1, "Ayesha", 5000, 1000),
            new PartTimeEmployee(2, "Vanshika", 20, 80)
        };

        employees[0] is IDepartment fullTimeDepartment ? fullTimeDepartment.AssignDepartment("IT") : null;
        employees[1] is IDepartment partTimeDepartment ? partTimeDepartment.AssignDepartment("HR") : null;

        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
            if (emp is IDepartment department)
            {
                Console.WriteLine(department.GetDepartmentDetails());
            }
            Console.WriteLine();
        }
    }
}

