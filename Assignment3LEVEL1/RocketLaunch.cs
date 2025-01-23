using System;
class RocketLaunch{
    static void Main(string[] args){
        int counter;

        // For user input
        Console.Write("Enter a number to start countdown: ");
        counter = Convert.ToInt32(Console.ReadLine());

        // Countdown using while loop
        while (counter > 0){
            Console.WriteLine(counter);
            counter--;
 }}}