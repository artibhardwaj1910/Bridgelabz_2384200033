using System;

namespace InheritenceAssignment
{
    // Base class Course
    class Course
    {
        protected string courseName;
        protected int duration; // in weeks

        // Constructor to initialize Course attributes
        public Course(string courseName, int duration)
        {
            this.courseName = courseName;
            this.duration = duration;
        }

        // Method to display course details
        public virtual void DisplayCourseInfo()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Duration: " + duration + " weeks");
        }
    }

    // Subclass OnlineCourse inheriting from Course
    class OnlineCourse : Course
    {
        protected string platform;
        protected string isRecorded; // Yes or No

        // Constructor to initialize OnlineCourse attributes
        public OnlineCourse(string courseName, int duration, string platform, string isRecorded)
            : base(courseName, duration)
        {
            this.platform = platform;
            this.isRecorded = isRecorded;
        }

        // Overriding DisplayCourseInfo to include online course details
        public override void DisplayCourseInfo()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Duration: " + duration + " weeks");
            Console.WriteLine("Platform: " + platform);
            Console.WriteLine("Recorded: " + isRecorded);
        }
    }

    // Subclass PaidOnlineCourse inheriting from OnlineCourse
    class PaidOnlineCourse : OnlineCourse
    {
        private double fee;
        private double discount; // in percentage

        // Constructor to initialize PaidOnlineCourse attributes
        public PaidOnlineCourse(string courseName, int duration, string platform, string isRecorded, double fee, double discount)
            : base(courseName, duration, platform, isRecorded)
        {
            this.fee = fee;
            this.discount = discount;
        }

        // Overriding DisplayCourseInfo to include paid course details
        public override void DisplayCourseInfo()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Duration: " + duration + " weeks");
            Console.WriteLine("Platform: " + platform);
            Console.WriteLine("Recorded: " + isRecorded);
            Console.WriteLine("Course Fee: ₹" + fee);
            Console.WriteLine("Discount: " + discount + "%");
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            // Creating an object of PaidOnlineCourse
            PaidOnlineCourse course = new PaidOnlineCourse("Data Science", 12, "Coursera", "Yes", 15000, 10);

            // Displaying course details
            course.DisplayCourseInfo();
        }
    }
}
