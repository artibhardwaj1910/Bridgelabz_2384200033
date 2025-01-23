using System;
class SumUntilEnterZero{
    static void Main(string[] args){
        double total = 0;
        double num;

        // For user input
        while (true){
            Console.Write("Enter a number (0 or negative to stop): ");
            num = Convert.ToDouble(Console.ReadLine());

            if (num <= 0)
                break;

            total += num;}

        Console.WriteLine("Total sum: " + total);
 }}