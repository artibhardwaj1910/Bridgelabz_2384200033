using System;
namespace GenericsAssignment{
abstract class CourseType
{
    public string EvaluationMethod { get; set; }

    public CourseType(string method)
    {
        EvaluationMethod = method;
    }

    public abstract void Describe();
}

class ExamCourse : CourseType
{
    public ExamCourse() : base("Final Exam") { }

    public override void Describe()
    {
        Console.WriteLine($"This course is evaluated through a {EvaluationMethod}.");
    }
}

class AssignmentCourse : CourseType
{
    public AssignmentCourse() : base("Assignments") { }

    public override void Describe()
    {
        Console.WriteLine($"This course is evaluated through {EvaluationMethod}.");
    }
}

class Course
{
    public string CourseName { get; set; }
    public string Department { get; set; }
    public CourseType CourseCategory { get; set; }

    public Course(string courseName, string department, CourseType courseCategory)
    {
        CourseName = courseName;
        Department = department;
        CourseCategory = courseCategory;
    }

    public void DisplayCourseInfo()
    {
        Console.WriteLine($"Course: {CourseName} | Department: {Department}");
        CourseCategory.Describe();
    }
}

class CourseManager
{
    private Course[] courses;
    private int count = 0;

    public CourseManager(int capacity)
    {
        courses = new Course[capacity];
    }

    public void AddCourse(Course course)
    {
        if (count < courses.Length)
        {
            courses[count] = course;
            count++;
        }
        else
        {
            Console.WriteLine("Course list is full!");
        }
    }

    public void DisplayAllCourses()
    {
        Console.WriteLine("\nUniversity Courses:");
        for (int i = 0; i < count; i++)
        {
            courses[i].DisplayCourseInfo();
        }
    }
}

class Program
{
    static void Main()
    {
        Course mathCourse = new Course("Mathematics", "Science", new ExamCourse());
        Course historyCourse = new Course("History", "Arts", new AssignmentCourse());

        CourseManager manager = new CourseManager(5);
        manager.AddCourse(mathCourse);
        manager.AddCourse(historyCourse);

        manager.DisplayAllCourses();
    }
}

}