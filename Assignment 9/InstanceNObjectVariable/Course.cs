using System;
namespace InstanceNObjectVariable{
	class Course{
	
		//class variable
		private static string instituteName = "GLA University";
		
		//instance variable
		private string courseName;
		private int duration;
		private int fee;
		
		//constructor to initialize
		public Product(string courseName, int duration, double fee){
		this.courseName = courseName;
		this.duration = duration;
		this.fee = fee;
		}
		
		// Getters and Setters
        public string GetCourseName()
        {
            return courseName;
        }

        public void SetCourseName(string courseName)
        {
            this.courseName = courseName;
        }

        public int GetDuration()
        {
            return duration;
        }

        public void SetDuration(int duration)
        {
            this.duration = duration;
        }

        public int GetFee()
        {
            return fee;
        }

        public void SetFee(int fee)
        {
            this.fee = fee;
        }

        // Instance Method to Display course details
        public void DisplayCourseDetails()
        {
            Console.WriteLine($"Institute Name: {instituteName}");
            Console.WriteLine($"Course Name: {courseName}");
            Console.WriteLine($"Duration: {duration} weeks");
            Console.WriteLine($"Fee: ${fee}");
            Console.WriteLine();
        }

        // Class Method to Update the institute name
        public static void UpdateInstituteName(string newInstituteName)
        {
            instituteName = newInstituteName;
        }
	}	
}		
		
		