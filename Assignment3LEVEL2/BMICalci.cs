using System;
class BMICalci{
    static void Main(){
        // For the user to enter their weight in kilograms
        Console.Write("Enter your weight in kg: ");
        double weight = Convert.ToDouble(Console.ReadLine()); // Store the weight as a double

        // For the user to enter their height in centimeters
        Console.Write("Enter your height in cm: ");
        double heightCm = Convert.ToDouble(Console.ReadLine()); // Store the height as a double

        // Convert height from cm to m
        double heightM = heightCm / 100;

        // Calculate BMI 
        double bmi = weight / (heightM * heightM);

        // Determine the weight status based on the BMI value
        string status;
        if (bmi <= 18.4){
            status = "Underweight";}
        else if (bmi >= 18.5 && bmi <= 24.9){
            status = "Normal";}
        else if (bmi >= 25.0 && bmi <= 39.9){
            status = "Overweight";}
        else{
            status = "Obese";}

        // Display the BMI result
        Console.WriteLine($"Your BMI is: {bmi:F2}");
        Console.WriteLine($"You are categorized as: {status}"); }}