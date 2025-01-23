using System;
class Natural{
    static void Main(string[] args){
        int number;

        // For user input
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number > 0){
            int sum = number * (number + 1) / 2;
            Console.WriteLine("The sum of {0} natural numbers is {1}", number, sum);}
        else{
            Console.WriteLine("The number {0} is not a natural number", number); }}}