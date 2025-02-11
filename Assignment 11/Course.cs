using System;
using System.Collections.Generic;

namespace ObjectModelAssignment
{
    class Course
    {
        private string courseName;
        private List<Student> enrolledStudents; 
        private Professor professor;

        // Constructor
        public Course(string courseName)
        {
            this.courseName = courseName;
            this.enrolledStudents = new List<Student>();
            this.professor = null;
        }

        // Getter method 
        public string GetCourseName()
        {
            return courseName;
        }

        // Method to assign a professor to the course
        public void AssignProfessor(Professor professor)
        {
            this.professor = professor;
            Console.WriteLine($"Professor {professor.GetProfessorName()} is assigned to teach {courseName}.");
        }

        // Method to enroll a student in the course
        public void EnrollStudent(Student student)
        {
            enrolledStudents.Add(student);
            Console.WriteLine($"{student.GetStudentName()} has enrolled in {courseName}.");
        }

        // Method to display course details
        public void DisplayCourseDetails()
        {
            Console.WriteLine($"Course: {courseName}");
            Console.WriteLine($"Professor: {(professor != null ? professor.GetProfessorName() : "Not Assigned")}");
            Console.WriteLine("Enrolled Students:");
            foreach (Student student in enrolledStudents)
            {
                Console.WriteLine($"- {student.GetStudentName()}");
            }
            Console.WriteLine();
        }
    }

    // Student class representing university students
    class Student
    {
        private string studentName;
        private int studentID;
        private List<Course> courses; 

        // Constructor to initialize student details
        public Student(string studentName, int studentID)
        {
            this.studentName = studentName;
            this.studentID = studentID;
            this.courses = new List<Course>();
        }

        // Getter method for student name
        public string GetStudentName()
        {
            return studentName;
        }

        // Method to enroll in a course
        public void EnrollCourse(Course course)
        {
            courses.Add(course);
            course.EnrollStudent(this);
        }

        // Method to display student's courses
        public void DisplayCourses()
        {
            Console.WriteLine($"{studentName} is enrolled in:");
            foreach (Course course in courses)
            {
                Console.WriteLine($"- {course.GetCourseName()}");
            }
            Console.WriteLine();
        }
    }

    // Professor class representing university professors
    class Professor
    {
        private string professorName;
        private string department;
        private List<Course> courses; 
        // Constructor to initialize professor details
        public Professor(string professorName, string department)
        {
            this.professorName = professorName;
            this.department = department;
            this.courses = new List<Course>();
        }

        // Getter method for professor name
        public string GetProfessorName()
        {
            return professorName;
        }

        // Method to assign a professor to a course
        public void AssignCourse(Course course)
        {
            courses.Add(course);
            course.AssignProfessor(this);
        }

        // Method to display courses taught by the professor
        public void DisplayCourses()
        {
            Console.WriteLine($"Professor {professorName} teaches:");
            foreach (Course course in courses)
            {
                Console.WriteLine($"- {course.GetCourseName()}");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating course objects
            Course course1 = new Course("Computer Science");
            Course course2 = new Course("Mathematics");

            // Creating professor objects
            Professor professor1 = new Professor("Dr. Smith", "Computer Science");
            Professor professor2 = new Professor("Dr. Johnson", "Mathematics");

            // Creating student objects
            Student student1 = new Student("Alice", 101);
            Student student2 = new Student("Bob", 102);

            // Assigning professors to courses
            professor1.AssignCourse(course1);
            professor2.AssignCourse(course2);

            // Students enrolling in courses
            student1.EnrollCourse(course1);
            student1.EnrollCourse(course2);
            student2.EnrollCourse(course1);

            // Displaying course details
            course1.DisplayCourseDetails();
            course2.DisplayCourseDetails();

            // Displaying students' enrolled courses
            student1.DisplayCourses();
            student2.DisplayCourses();

            // Displaying professors' assigned courses
            professor1.DisplayCourses();
            professor2.DisplayCourses();
        }
    }
}
