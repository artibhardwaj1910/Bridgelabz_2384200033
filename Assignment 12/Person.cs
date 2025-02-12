using System;

namespace InheritenceAssignment
{
    // Base class Person
    class Person
    {
        protected string name;
        protected int age;

        // Constructor to initialize Person attributes
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Method to display common details
        public void DisplayPersonDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    // Subclass Teacher inheriting from Person
    class Teacher : Person
    {
        private string subject;

        // Constructor to initialize Teacher attributes
        public Teacher(string name, int age, string subject) 
            : base(name, age)
        {
            this.subject = subject;
        }

        // Method to display role
        public void DisplayRole()
        {
            Console.WriteLine("Role: Teacher");
            DisplayPersonDetails();
            Console.WriteLine("Subject: " + subject);
        }
    }

    // Subclass Student inheriting from Person
    class Student : Person
    {
        private string grade;

        // Constructor to initialize Student attributes
        public Student(string name, int age, string grade) 
            : base(name, age)
        {
            this.grade = grade;
        }

        // Method to display role
        public void DisplayRole()
        {
            Console.WriteLine("Role: Student");
            DisplayPersonDetails();
            Console.WriteLine("Grade: " + grade);
        }
    }

    // Subclass Staff inheriting from Person
    class Staff : Person
    {
        private string department;

        // Constructor to initialize Staff attributes
        public Staff(string name, int age, string department) 
            : base(name, age)
        {
            this.department = department;
        }

        // Method to display role
        public void DisplayRole()
        {
            Console.WriteLine("Role: Staff");
            DisplayPersonDetails();
            Console.WriteLine("Department: " + department);
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            // Creating objects of different roles
            Teacher teacher = new Teacher("Rajesh Sharma", 40, "Mathematics");
            Student student = new Student("Ananya Verma", 16, "10th Grade");
            Staff staff = new Staff("Suresh Patel", 45, "Administration");

            // Displaying roles and details
            teacher.DisplayRole();
            Console.WriteLine();
            student.DisplayRole();
            Console.WriteLine();
            staff.DisplayRole();
        }
    }
}
