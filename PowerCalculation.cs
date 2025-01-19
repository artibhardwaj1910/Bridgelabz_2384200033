using System;

namespace PowerCalculation{

	class Program{
		public static void Main(string[] args){
	
			Console.WriteLine("Enter the base");
			int baseNum = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the exponent");
			int exponent = Convert.ToInt32(Console.ReadLine());
			double result = Math.Pow(baseNum,exponent) ;
			Console.WriteLine(result);
	
		}
	}
}