using System;
class PersonVote{
    static void Main(string[] args){
        int age;

        // For user input
        Console.Write("Enter age: ");
        age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18){
            Console.WriteLine("The person's age is {0} and can vote.", age);}
        else{
            Console.WriteLine("The person's age is {0} and cannot vote.", age); }}}