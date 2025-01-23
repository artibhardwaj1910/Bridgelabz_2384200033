using System;
class CreateCalculator{
    static void Main(string[] args){
 
        double first, second;
        string op;

        // For user input
        Console.Write("Enter the first number: ");
        first = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        second = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the operator (+, -, *, /): ");
        op = Console.ReadLine();

        // Perform calculation using switch case
        switch (op){
            case "+":
                Console.WriteLine("Result: {0} + {1} = {2}", first, second, first + second);
                break;

            case "-":
                Console.WriteLine("Result: {0} - {1} = {2}", first, second, first - second);
                break;

            case "*":
                Console.WriteLine("Result: {0} * {1} = {2}", first, second, first * second);
                break;

            case "/":
                // Handle DivideByZeroException
                if (second != 0){
                    Console.WriteLine("Result: {0} / {1} = {2}", first, second, first / second);}
                else{
                    Console.WriteLine("Error: Division by zero is not allowed.");}
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
}}}