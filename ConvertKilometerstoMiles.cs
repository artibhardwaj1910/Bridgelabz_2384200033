using System;

namespace ConvertKilometerstoMiles{

	class Program{
		public static void Main(string[] args){
			Console.WriteLine("Enter the Kilometers");
			int Kilometers = Convert.ToInt32(Console.ReadLine());
			double Miles = Kilometers * 0.621371;
			Console.WriteLine(Miles);
	}
	}
}