using System;
class BMICalculator{
    static void Main(){
        // For user input
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());

        // Define array to store values
        double[] heights = new double[numPersons];
        double[] weights = new double[numPersons];
        double[] bmis = new double[numPersons];
        string[] statuses = new string[numPersons];

        // Loop to collect data for each person
        for (int i = 0; i < numPersons; i++){
            Console.WriteLine($"\nPerson {i + 1}");

            // Input height (in meters)
            Console.Write("Enter height (in meters): ");
            heights[i] = double.Parse(Console.ReadLine());

            // Input weight (in kilograms)
            Console.Write("Enter weight (in kg): ");
            weights[i] = double.Parse(Console.ReadLine());

            // Calculate BMI
            bmis[i] = Math.Round(weights[i] / (heights[i] * heights[i]), 2);

            // Determine weight status
            statuses[i] = DetermineStatus(bmis[i]);}

        // Display the result
        Console.WriteLine("\nResults:");
        Console.WriteLine($"{ "Height (m)",-12}{ "Weight (kg)",-12}{ "BMI",-8}{ "Status"}");
        for (int i = 0; i < numPersons; i++){
            Console.WriteLine($"{heights[i],-12}{weights[i],-12}{bmis[i],-8}{statuses[i]}"); }}

    // Method to determine weight status based on BMI
    static string DetermineStatus(double bmi){
        if (bmi <= 18.4)
            return "Underweight";
        else if (bmi >= 18.5 && bmi <= 24.9)
            return "Normal";
        else if (bmi >= 25.0 && bmi <= 39.9)
            return "Overweight";
        else
            return "Obese"; }}