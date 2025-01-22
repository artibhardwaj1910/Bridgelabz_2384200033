using System;
namespace Program{
    class BasicCalculator{
        static void Main(string[] args){
            // For user input
            Console.WriteLine("Enter the first number:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Arithmetic operations
            double addition = number1 + number2;
            double subtraction = number1 - number2;
            double multiplication = number1 * number2;
            double division = number2 != 0 ? number1 / number2 : double.NaN; // DivideByZeroException

            // Display the result
            Console.WriteLine("The addition, subtraction, multiplication, and division values of the numbers " + number1 + " and " + number2 + " are: ");
            Console.WriteLine("Addition: " + addition);
            Console.WriteLine("Subtraction: " + subtraction);
            Console.WriteLine("Multiplication: " + multiplication);
            Console.WriteLine("Division: " + (number2 != 0 ? division.ToString() : "undefined (division by zero)")); }}}