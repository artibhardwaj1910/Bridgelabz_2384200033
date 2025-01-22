using System;
namespace Program{
    class IncomeOfPerson{
        static void Main(string[] args){
            // For user input
            Console.Write("Enter the salary (INR): ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the bonus (INR): ");
            double bonus = Convert.ToDouble(Console.ReadLine());

            // Calculate total income
            double totalIncome = salary + bonus;

            // Display the result
            Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence, Total Income is INR {totalIncome}."); }}}