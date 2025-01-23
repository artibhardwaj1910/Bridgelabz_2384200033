using System;
class Largest{
    static void Main(string[] args){
        int number1, number2, number3;

        // For user input
        Console.Write("Enter first number: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        number3 = Convert.ToInt32(Console.ReadLine());

        // Check for the largest number
        if (number1 > number2 && number1 > number3){
            Console.WriteLine("Is the first number the largest? Yes");}
        else{
            Console.WriteLine("Is the first number the largest? No");}

        if (number2 > number1 && number2 > number3){
            Console.WriteLine("Is the second number the largest? Yes");}
        else{
            Console.WriteLine("Is the second number the largest? No");}

        if (number3 > number1 && number3 > number2){
            Console.WriteLine("Is the third number the largest? Yes");}
        else{
            Console.WriteLine("Is the third number the largest? No");
}}}