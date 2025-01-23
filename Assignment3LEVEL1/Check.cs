using System;
class Check{
        static void Main(string[] args){
          int number;

        // For user input
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is divisible by 5 
        if (number % 5 == 0){
            Console.WriteLine("Is the number {0} divisible by 5? Yes", number);}
        else{
            Console.WriteLine("Is the number {0} divisible by 5? No", number); }}}