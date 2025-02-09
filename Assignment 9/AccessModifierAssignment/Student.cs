using System;
namespace AccessModifierAssignment{
		//Base class
		public class Student{
		
		// attributes
		public int rollNo;
		protected string name;
		private float CGPA;
		
		public Student(int rollNo, string name, float CGPA){
		this.rollNo = rollNo;
		this.name = name;
		this.CGPA = CGPA;
		}
		
		//getters and setters
		public float GetCGPA(){
		return CGPA;
		}
		
		public void SetCGPA(float CGPA){
		this.CGPA = CGPA;
		}
		
		
		
	}
	
	// Derived class PostgraduateStudent 
	class PostgraduateStudent: Student{
	
		 public PostgraduateStudent(int rollNo, string name, float CGPA) 
            : base(rollNo, name, CGPA)
        {
        }
		
		public void Display()
        {
            Console.WriteLine("Postgraduate Student Name: " + name);
        }
	}
	
	}
}