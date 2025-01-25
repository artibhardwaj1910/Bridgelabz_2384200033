using System;
class FizzBuzz{
    static void Main(){
        // For user input
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is positive
        if (number <= 0){
            Console.WriteLine("Please enter a positive integer.");
            return;}

        // Create a string array to store the results
        string[] fizzBuzzArray = new string[number + 1];

        // Loop from 0 to the input number and apply FizzBuzz logic
        for (int i = 0; i <= number; i++){
            if (i % 3 == 0 && i % 5 == 0){
                fizzBuzzArray[i] = "FizzBuzz";}
            else if (i % 3 == 0){
                fizzBuzzArray[i] = "Fizz";}
            else if (i % 5 == 0){
                fizzBuzzArray[i] = "Buzz";}             }
            else{
                fizzBuzzArray[i] = i.ToString();}}

        // Display the result
        for (int i = 0; i <= number; i++){
            Console.WriteLine($"Position {i} = {fizzBuzzArray[i]}"); }}}