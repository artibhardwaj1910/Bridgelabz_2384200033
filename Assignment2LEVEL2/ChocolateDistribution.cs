using System;
namespace Program{
    class ChocolateDistribution{
        static void Main(string[] args){
            // For user input
            Console.Write("Enter the number of chocolates: ");
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of children: ");
            int numberOfChildren = Convert.ToInt32(Console.ReadLine());

            // Calculate chocolates 
            int chocolatesPerChild = numberOfChocolates / numberOfChildren;
            int remainingChocolates = numberOfChocolates % numberOfChildren;

            // Display the result
            Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} and the number of remaining chocolates is {remainingChocolates}."); }}}