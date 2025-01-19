using System;

namespace PerimeterofRectangle{

	class Program{
	public static void Main(string[] args){
	
	Console.WriteLine("Enter the length");
	int length = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter the width");
	int width = Convert.ToInt32(Console.ReadLine());
	int Perimeter = 2 * (length + width) ;
	Console.WriteLine("Perimeter of Rectangle : " +Perimeter);
	
	}
	}
}