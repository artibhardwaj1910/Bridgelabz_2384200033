using System;
namespace Program{
    class HeightConverter{
        static void Main(string[] args){
            // Declare variables
            double heightInCm;
            double heightInInches;
            int heightInFeet;

            const double cmToInchConversionFactor = 2.54;
            const int inchesPerFoot = 12;

            // For user input
            Console.WriteLine("Enter your height in centimeters:");
            heightInCm = Convert.ToDouble(Console.ReadLine());

            // Convert heightInInches
            heightInInches = heightInCm / cmToInchConversionFactor;

            // Calculate heightInFeet 
            heightInFeet = (int)(heightInInches / inchesPerFoot);
            double remainingInches = heightInInches % inchesPerFoot;

            // Display the result
            Console.WriteLine($"Your height in cm is {heightInCm}, while in feet it is {heightInFeet} feet and {remainingInches:F2} inches."); }}}