using System;
using System.Collections.Generic;

namespace ObjectModelAssignment
{
    class Course
    {
        private string courseName;
        private List<Student> enrolledStudents; 

        // Constructor 
        public Course(string courseName)
        {
            this.courseName = courseName;
            this.enrolledStudents = new List<Student>();
        }

        // Getter method for course name
        public string GetCourseName()
        {
            return courseName;
        }

        // Method to enroll a student in the course
        public void EnrollStudent(Student student)
        {
            if (!enrolledStudents.Contains(student))
            {
                enrolledStudents.Add(student);
            }
        }

        // Method to display enrolled students
        public void DisplayEnrolledStudents()
        {
            Console.WriteLine($"Students enrolled in {courseName}:");
            foreach (Student student in enrolledStudents)
            {
                Console.WriteLine($"- {student.GetStudentName()}");
            }
            Console.WriteLine();
        }
    }

    // Student class representing a student
    class Student
    {
        private string studentName;
        private List<Course> enrolledCourses; // Association: A student can enroll in multiple courses

        // Constructor to initialize student details
        public Student(string studentName)
        {
            this.studentName = studentName;
            this.enrolledCourses = new List<Course>();
        }

        // Getter method for student name
        public string GetStudentName()
        {
            return studentName;
        }

        // Method to enroll in a course
        public void EnrollInCourse(Course course)
        {
            if (!enrolledCourses.Contains(course))
            {
                enrolledCourses.Add(course);
                course.EnrollStudent(this); // Ensuring bidirectional association
            }
        }

        // Method to display enrolled courses
        public void DisplayEnrolledCourses()
        {
            Console.WriteLine($"{studentName} is enrolled in:");
            foreach (Course course in enrolledCourses)
            {
                Console.WriteLine($"- {course.GetCourseName()}");
            }
            Console.WriteLine();
        }
    }

    // School class representing an institution
    class School
    {
        private string schoolName;
        private List<Student> students; // Aggregation: A school has multiple students

        // Constructor to initialize school name and student list
        public School(string schoolName)
        {
            this.schoolName = schoolName;
            this.students = new List<Student>();
        }

        // Getter method for school name
        public string GetSchoolName()
        {
            return schoolName;
        }

        // Method to add a student to the school
        public void AddStudent(Student student)
        {
            if (!students.Contains(student))
            {
                students.Add(student);
            }
        }

        // Method to display all students
        public void DisplayStudents()
        {
            Console.WriteLine($"Students in {schoolName}:");
            foreach (Student student in students)
            {
                Console.WriteLine($"- {student.GetStudentName()}");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating a school object
            School school = new School("Greenwood High");

            // Creating student objects
            Student student1 = new Student("Alice");
            Student student2 = new Student("Bob");
            Student student3 = new Student("Charlie");

            // Adding students to the school
            school.AddStudent(student1);
            school.AddStudent(student2);
            school.AddStudent(student3);

            // Creating course objects
            Course math = new Course("Mathematics");
            Course science = new Course("Science");
            Course history = new Course("History");

            // Enrolling students in courses
            student1.EnrollInCourse(math);
            student1.EnrollInCourse(science);
            
            student2.EnrollInCourse(math);
            student2.EnrollInCourse(history);
            
            student3.EnrollInCourse(science);

            // Displaying enrolled students for each course
            math.DisplayEnrolledStudents();
            science.DisplayEnrolledStudents();
            history.DisplayEnrolledStudents();

            // Displaying courses for each student
            student1.DisplayEnrolledCourses();
            student2.DisplayEnrolledCourses();
            student3.DisplayEnrolledCourses();

            // Displaying all students in the school
            school.DisplayStudents();
        }
    }
}
