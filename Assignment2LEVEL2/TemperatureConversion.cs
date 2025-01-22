using System;
namespace Program{
    class TemperatureConversion{
        static void Main(string[] args){
            // For user input
            Console.Write("Enter the temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Convert Celsius to Fahrenheit
            double fahrenheitResult = (celsius * 9 / 5) + 32;

            // Display the result
            Console.WriteLine($"The {celsius} Celsius is {fahrenheitResult} Fahrenheit."); }}}