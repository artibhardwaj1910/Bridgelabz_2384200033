using System;
class Smallest{
    static void Main(string[] args){
        int number1, number2, number3;
        
        // For user input
        Console.Write("Enter first number: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        number3 = Convert.ToInt32(Console.ReadLine());

        // Check if first number is smallest
        if (number1 < number2 && number1 < number3){
            Console.WriteLine("Is the first number the smallest? Yes");}
        else{
            Console.WriteLine("Is the first number the smallest? No");
}}}