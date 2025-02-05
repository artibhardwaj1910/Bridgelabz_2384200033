using System;
namespace Assignment05Level3
{
class Scorecard{
    static void Main(string[] args){
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Generate random scores
        int[,] scores = GenerateRandomScores(numStudents);

        // Calculate total, average, and percentage
        double[,] results = CalculateResults(scores);

        // Display the scorecard
        DisplayScorecard(scores, results);}

    // Method to generate random scores for Physics, Chemistry, and Math
    static int[,] GenerateRandomScores(int numStudents){
        Random rand = new Random();
        int[,] scores = new int[numStudents, 3]; // 3 subjects: Physics, Chemistry, Math

        for (int i = 0; i < numStudents; i++){
            scores[i, 0] = rand.Next(40, 101); // Physics
            scores[i, 1] = rand.Next(40, 101); // Chemistry
            scores[i, 2] = rand.Next(40, 101); // Math }

        return scores; }

    // Method to calculate total, average, and percentage
    static double[,] CalculateResults(int[,] scores){
        int numStudents = scores.GetLength(0);
        double[,] results = new double[numStudents, 3]; // Total, Average, Percentage

        for (int i = 0; i < numStudents; i++){
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100;

            results[i, 0] = total;
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2); }

        return results; }

    // Method to display the scorecard
    static void DisplayScorecard(int[,] scores, double[,] results)
    {
        Console.WriteLine("Student\tPhysics\tChemistry\tMath\tTotal\tAverage\tPercentage");
        for (int i = 0; i < scores.GetLength(0); i++){
            Console.Write($"Student {i + 1}\t");
            Console.Write($"{scores[i, 0]}\t");
            Console.Write($"{scores[i, 1]}\t\t");
            Console.Write($"{scores[i, 2]}\t");
            Console.Write($"{results[i, 0]}\t");
            Console.Write($"{results[i, 1]}\t");
            Console.WriteLine($"{results[i, 2]}%"); 
