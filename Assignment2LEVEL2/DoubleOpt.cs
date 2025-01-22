using System;
namespace Program{
    class DoubleOpt{
        static void Main(string[] args){
            // For user input
            Console.Write("Enter the value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Performing double operations
            double result1 = a + b * c;     
            double result2 = a * b + c;    
            double result3 = c + a / b;      
            double result4 = a % b + c;    

            // Display the result
            Console.WriteLine($"The results of Double Operations are: {result1}, {result2}, {result3}, and {result4}"); }}}