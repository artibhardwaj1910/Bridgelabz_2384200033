using System;
class FizzBuzz2{
    static void Main(){
        // For user input
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        int i = 0; // Initialize the counter variable

        //While loop
        while (i <= number){
            // Print "FizzBuzz" for multiples of 3 and 5
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            // Print "Fizz" for multiples of 3
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            // Print "Buzz" for multiples of 5
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            // Print the number for all other cases
            else
                Console.WriteLine(i);

            i++;
}}}
