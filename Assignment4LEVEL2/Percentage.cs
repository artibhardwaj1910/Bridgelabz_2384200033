using System;
class Percentage{
    static void Main(){
        // For user input
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Arrays to store marks, percentages, and grades
        int[,] marks = new int[numStudents, 3];
        double[] percentages = new double[numStudents];
        string[] grades = new string[numStudents];

        // Loop to collect marks for each student
        for (int i = 0; i < numStudents; i++){
            Console.WriteLine($"\nStudent {i + 1}");
            // Input marks for Physics, Chemistry, and Maths
            for (int j = 0; j < 3; j++){
                string subject = j == 0 ? "Physics" : j == 1 ? "Chemistry" : "Maths";
                int mark;
                do{
                    Console.Write($"Enter marks for {subject} (0-100): ");
                    mark = int.Parse(Console.ReadLine());
                    if (mark < 0 || mark > 100){
                        Console.WriteLine("Marks must be between 0 and 100. Please try again."); }}
                while (mark < 0 || mark > 100);
                marks[i, j] = mark;}

            // Calculate percentage
            percentages[i] = Math.Round((marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0, 2);

            grades[i] = DetermineGrade(percentages[i]);}

        // Display the result
        Console.WriteLine("\nResults:");
        Console.WriteLine($"{ "Physics",-10}{ "Chemistry",-12}{ "Maths",-8}{ "Percentage",-12}{ "Grade"}");
        for (int i = 0; i < numStudents; i++){
            Console.WriteLine($"{marks[i, 0],-10}{marks[i, 1],-12}{marks[i, 2],-8}{percentages[i],-12}{grades[i]}"); }}

    // Method to determine grade based on percentage
    static string DetermineGrade(double percentage){
        if (percentage >= 80)
            return "A";
        else if (percentage >= 70)
            return "B";
        else if (percentage >= 60)
            return "C";
        else if (percentage >= 50)
            return "D";
        else if (percentage >= 40)
            return "E";
        else
            return "R"; }}