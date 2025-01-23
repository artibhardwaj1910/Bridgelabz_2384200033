using System;
class Abundant{
    static void Main(string[] args){
        int number, sum = 0;

        // For user input
        Console.Write("Enter an integer: ");
        number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < number; i++){
            // Check if i is a divisor of the number
            if (number % i == 0){
                sum += i; }}

        // Check if the sum of divisors is greater than the number
        if (sum > number){
            Console.WriteLine("{0} is an Abundant Number.", number);}
        else{
            Console.WriteLine("{0} is not an Abundant Number.", number);
}}}