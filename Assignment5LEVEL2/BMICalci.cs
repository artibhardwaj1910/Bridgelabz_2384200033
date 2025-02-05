using System;
public class BMICalci{
    // Method to calculate BMI for each person 
    public static void CalculateBMI(double[,] data){
        for (int i = 0; i < data.GetLength(0); i++){
            double weight = data[i, 0];
            double heightInMeters = data[i, 1] / 100;
            data[i, 2] = weight / (heightInMeters * heightInMeters); }}

    // Method to determine BMI status based on the provided ranges
    public static string[] DetermineBMIStatus(double[,] data){
        string[] statuses = new string[data.GetLength(0)];

        for (int i = 0; i < data.GetLength(0); i++){
            double bmi = data[i, 2];
            if (bmi <= 18.4){
                statuses[i] = "Underweight";}
            else if (bmi <= 24.9){
                statuses[i] = "Normal";}
            else if (bmi <= 39.9){
                statuses[i] = "Overweight";}
            else{
                statuses[i] = "Obese"; }}
        return statuses; }

    public static void Main(string[] args){
        // Array to store weight, height, and BMI for 10 members
        double[,] data = new double[10, 3];

        Console.WriteLine("Enter the weight (in kg) and height (in cm) for 10 members:");

        // Taking input for weight and height
        for (int i = 0; i < 10; i++){
            Console.Write($"Member {i + 1} - Weight (kg): ");
            data[i, 0] = double.Parse(Console.ReadLine());

            Console.Write($"Member {i + 1} - Height (cm): ");
            data[i, 1] = double.Parse(Console.ReadLine());}

        // Calculate BMI and populate the data array
        CalculateBMI(data);

        // Determine BMI statuses for all members
        string[] statuses = DetermineBMIStatus(data);

        // Display the results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Member\tWeight(kg)\tHeight(cm)\tBMI\t\tStatus");
        for (int i = 0; i < 10; i++){
            Console.WriteLine($"{i + 1}\t{data[i, 0]:F2}\t\t{data[i, 1]:F2}\t\t{data[i, 2]:F2}\t\t{statuses[i]}");
}}}

