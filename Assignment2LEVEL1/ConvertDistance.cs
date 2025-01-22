using System;
namespace Program{
    class ConvertDistance{
        public static void Main(string[] args){
            // Declare variables
            double distanceInKilometers;
            double kilometersToMilesFactor;
            double distanceInMiles;

            // Initialize the values
            distanceInKilometers = 10.8;
            kilometersToMilesFactor = 1.6;

            // Calculate the distance in miles
            distanceInMiles = distanceInKilometers * kilometersToMilesFactor;

            // Output the result
            Console.WriteLine("The distance 10.8 km in miles is: " + distanceInMiles); }}}