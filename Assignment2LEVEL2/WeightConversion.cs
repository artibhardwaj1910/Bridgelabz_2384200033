using System;
namespace Program{
    class WeightConversion{
        static void Main(string[] args){
            // For user input
            Console.Write("Enter the weight in pounds: ");
            double weightInPounds = Convert.ToDouble(Console.ReadLine());

            // Conversion
            double weightInKg = weightInPounds * 2.2;

            // Display the result
            Console.WriteLine($"The weight of the person in pounds is {weightInPounds} and in kg is {weightInKg}."); }}}