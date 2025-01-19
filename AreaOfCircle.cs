using System;

namespace AreaOfCircle{

	class Program{
	public static void Main(string[] args){
	float pi = 3.14F;
	Console.WriteLine("Enter the Radius");
	int radius = Convert.ToInt32(Console.ReadLine());
	float Area = pi * radius * radius;
	Console.WriteLine("Area of circle :"+Area);
	
	}
	}
}