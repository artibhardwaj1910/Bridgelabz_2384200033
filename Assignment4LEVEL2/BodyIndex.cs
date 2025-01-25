using System;
class BodyIndex{
    static void Main(){
        // For user input
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());

        // Multi-dimensional array to store values
        double[][] personData = new double[numPersons][];
        for (int i = 0; i < numPersons; i++){
            personData[i] = new double[3];}

        // Array to store weight status
        string[] weightStatus = new string[numPersons];

        // Loop to collect data for each person
        for (int i = 0; i < numPersons; i++){
            Console.WriteLine($"\nPerson {i + 1}");

            // Input height (in meters)
            double height;
            do{
                Console.Write("Enter height (in meters, positive value): ");
                height = double.Parse(Console.ReadLine());
                if (height <= 0){
                    Console.WriteLine("Height must be a positive value. Please try again."); }}
            while (height <= 0);
            personData[i][0] = height;

            // Input weight (in kilograms)
            double weight;
            do{
                Console.Write("Enter weight (in kg, positive value): ");
                weight = double.Parse(Console.ReadLine());
                if (weight <= 0){
                    Console.WriteLine("Weight must be a positive value. Please try again."); }}
            while (weight <= 0);
            personData[i][1] = weight;

            // Calculate BMI
            personData[i][2] = Math.Round(weight / (height * height), 2);

            // Determine weight status
            weightStatus[i] = DetermineStatus(personData[i][2]); }

        // Display the result
        Console.WriteLine("\nResults:");
        Console.WriteLine($"{ "Height (m)",-12}{ "Weight (kg)",-12}{ "BMI",-8}{ "Status"}");
        for (int i = 0; i < numPersons; i++){
            Console.WriteLine($"{personData[i][0],-12}{personData[i][1],-12}{personData[i][2],-8}{weightStatus[i]}"); }}

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