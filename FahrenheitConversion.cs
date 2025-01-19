using System;

namespace FahrenheitConversion{

	class Program{
	public static void Main(string[] args){
	Console.WriteLine("Enter the Celsius");
	int Celsius = Convert.ToInt32(Console.ReadLine());
	float Fahrenheit = (Celsius * 9/5) + 32;
	Console.WriteLine(Fahrenheit);
	
	}
	}
}