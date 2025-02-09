using System;
namespace ConstructorAssignment{
	class Circle{
		
		// Declare Attribute
		private int radius;
		
		//default constructor
		public Circle(){
		this.radius = 5;
		}
		
		//parameterized Constructor
		public Circle(int radius){
		this.radius = radius;
		}
		
		//getter
		public int GetRadius(){
		return radius;
		}
		
		//setter
		
		public void SetRadius(int radius){
		this.radius = radius;
		}
		
		// Display Circle Detail
        public void Display()
        {
            Console.WriteLine("Radius of the Circle: " + radius);
        }
		
	}
}