using System;
class Countdown{
    static void Main(string[] args){
        int counter;

        // For user input
        Console.Write("Enter a number to start countdown: ");
        counter = Convert.ToInt32(Console.ReadLine());

        // Countdown using for loop
        for (int i = counter; i > 0; i--){
            Console.WriteLine(i);
 }}}