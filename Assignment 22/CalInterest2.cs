using System;
using System.IO;
class CalInterest2
{
    static double CalculateInterest(double amount, double rate, int years)
    {
        if (amount < 0 || rate < 0)
        {
            throw new ArgumentException("Amount and rate must be positive");
        }
        return amount * rate * years / 100;
    }

    static void PerformDivision(int numerator, int denominator)
    {
        try
        {
            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Operation completed.");
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter principal amount: ");
            double amount = double.Parse(Console.ReadLine());
            
            Console.Write("Enter interest rate: ");
            double rate = double.Parse(Console.ReadLine());
            
            Console.Write("Enter number of years: ");
            int years = int.Parse(Console.ReadLine());
            
            double interest = CalculateInterest(amount, rate, years);
            Console.WriteLine("Calculated Interest: " + interest);
            
            Console.Write("Enter numerator for division: ");
            int numerator = int.Parse(Console.ReadLine());
            
            Console.Write("Enter denominator for division: ");
            int denominator = int.Parse(Console.ReadLine());
            
            PerformDivision(numerator, denominator);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Invalid input: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input: Please enter numeric values.");
        }
    }
}

