using System;
namespace KeywordAssignment
{
    class Student
    {
        private static string universityName = "State University"; 
        private static int totalStudents = 0; 
        private readonly int rollNumber; 
        private string name;
        private string grade;

        public Student(string name, int rollNumber, string grade)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.grade = grade;
            totalStudents++;
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine($"Total Students: {totalStudents}");
        }

        public void DisplayStudentDetails()
        {
            if (this is Student) 
            {
                Console.WriteLine($"University: {universityName}");
                Console.WriteLine($"Student Name: {name}");
                Console.WriteLine($"Roll Number: {rollNumber}");
                Console.WriteLine($"Grade: {grade}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Student student1 = new Student("Emma Brown", 101, "A");
            student1.DisplayStudentDetails();
            Student.DisplayTotalStudents();
        }
    }
}

