using System;
class LeapYear2{
    static void Main(){
        // For user input
        Console.Write("Enter a year (>= 1582): ");
        int year = int.Parse(Console.ReadLine());

        // Check if the year is valid
        if (year < 1582){
            Console.WriteLine("The year must be 1582 or later.");
            return;}

        // Determine if the year is a leap year with a single condition
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)){
            Console.WriteLine($"{year} is a Leap Year.");}
        else{
            Console.WriteLine($"{year} is not a Leap Year."); }}}