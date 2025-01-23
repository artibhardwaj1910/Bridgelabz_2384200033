using System;
class MarksCalculator{
    static void Main(){
        // For user input
        Console.Write("Enter marks for Physics: ");
        int physics = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Chemistry: ");
        int chemistry = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Maths: ");
        int maths = int.Parse(Console.ReadLine());

        // Calculate total marks and percentage
        int totalMarks = physics + chemistry + maths;
        double percentage = (double)totalMarks / 3;

        // Determine grade and remarks based on the percentage
        string grade;
        string remarks;

        if (percentage >= 80){
            grade = "A";
            remarks = "Level 4, above agency-normalized standards";}
        else if (percentage >= 70){
            grade = "B";
            remarks = "Level 3, at agency-normalized standards";}
        else if (percentage >= 60){
            grade = "C";
            remarks = "Level 2, below, but approaching agency-normalized standards";}
        else if (percentage >= 50){
            grade = "D";
            remarks = "Level 1, well below agency-normalized standards";}
        else if (percentage >= 40){
            grade = "E";
            remarks = "Level 1-, too below agency-normalized standards";}
        else{
            grade = "R";
            remarks = "Remedial standards";}

        // Display the result
        Console.WriteLine($"\nAverage Percentage: {percentage:F2}%");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Remarks: {remarks}"); }}