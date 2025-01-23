using System;
class OddEven{
    static void Main(string[] args){
        int number;

        // For user input
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number > 0){
            for (int i = 1; i <= number; i++){
                if (i % 2 == 0)
                    Console.WriteLine(i + " is even.");
                else
                    Console.WriteLine(i + " is odd."); }}
        else{
            Console.WriteLine("Not a valid number.");
 }}}