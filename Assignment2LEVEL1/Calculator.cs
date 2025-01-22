using System;
namespace Program{
    class Calculator{
        public static void Main(string[] args){
            // Declare variables and initializing value
            int costPrice = 129;
            int sellingPrice = 191;

            // Calculate profit and profitPercentage
            int profit = sellingPrice - costPrice;
            float profitPercentage = (float)profit / costPrice * 100;
            // Display the result
            Console.WriteLine($@"
The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}
The Profit is INR {profit} and the Profit Percentage is {profitPercentage:F2}%
"); }}}