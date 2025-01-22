using System;
namespace Program{
    class TotalPrice{
        static void Main(string[] args){
            // Declare variables
            double unitPrice, quantity, totalPrice;

            // For user input
            Console.WriteLine("Enter the unit price of the item (INR):");
            unitPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the quantity to be bought:");
            quantity = Convert.ToDouble(Console.ReadLine());

            // Calculate totalPrice
            totalPrice = unitPrice * quantity;

            // Display the result
            Console.WriteLine($"The total purchase price is INR {totalPrice} if the quantity is {quantity} and the unit price is INR {unitPrice}."); }}}