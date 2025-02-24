using System;
using System.IO;
class DivisibleByZero
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the numerator: ");
            int numerator = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the denominator: ");
            int denominator = int.Parse(Console.ReadLine());
            
            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while reading input: " + ex.Message);
        }
    }
}

