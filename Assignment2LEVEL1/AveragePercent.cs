using System;
namespace Program{
    class AveragePercent{
        public static void Main(string[] args){
            // Declare variables and initializing values
            int mathsMark = 94;
            int physicsMark = 95;
            int chemistryMark = 96;

            // Calculate MarksObtained and averageMark
            int MarksObtained = mathsMark + physicsMark + chemistryMark;
            int numberOfSubjects = 3;
            int averageMark = totalMarksObtained / numberOfSubjects;

            // Output the result            
            Console.WriteLine("Sam's average mark in PCM is: " + averageMark); }}}