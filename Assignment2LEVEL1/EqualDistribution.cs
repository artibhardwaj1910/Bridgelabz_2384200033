using System;
namespace Program{
    class EqualDistribution{
        public static void Main(string[] args){
            // Declare variables and initializing value
            int totalPens = 14;
            int numberOfStudents = 3;
            
            // Calculate pensPerStudent and the remainingPens
            int pensPerStudent = totalPens / numberOfStudents;
            int remainingPens = totalPens % numberOfStudents;

            // Output the result
            Console.WriteLine("The Pen Per Student is " +  pensPerStudent + " and the remaining pen not distributed is: " + remainingPens); }}}