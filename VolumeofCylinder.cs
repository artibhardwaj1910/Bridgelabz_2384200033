using System;

namespace VolumeofCylinder{

	class Program{
	public static void Main(string[] args){
	float pi = 3.14F;
	Console.WriteLine("Enter the Radius");
	int radius = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter the Height");
	int height = Convert.ToInt32(Console.ReadLine());
	float Volume = pi * radius * radius * height ;
	Console.WriteLine("Volume of cylender :"+Volume);
	
	}
	}
}