using System;
class PositiveNegative{
    static void Main(string[] args){
        int number;

        // For user input
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number > 0){
            Console.WriteLine("Positive");}
        else if (number < 0){
            Console.WriteLine("Negative");}}
        else{{
            Console.WriteLine("Zero");
}}}