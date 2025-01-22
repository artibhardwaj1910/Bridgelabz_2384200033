using System;
namespace Program{
    class TemperatureConversion2{
        static void Main(string[] args){
            // For user input
            Console.Write("Enter the temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            // Convert Fahrenheit to Celsius
            double celsiusResult = (fahrenheit - 32) * 5 / 9;

            // Display the result
            Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsiusResult} Celsius."); }}}