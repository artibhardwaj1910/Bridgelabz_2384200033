using System;
namespace Program{
    class FeeCalculate{
        public static void Main(string[] args){
            // Declare variables and initializing value
            int fee = 125000;
            int discountPercent = 10;

            // Calculate the discount and finalFee
            double discount = (fee * discountPercent) / 100.0;
            double finalFee = fee - discountAmount;

            // Output the result
            Console.WriteLine("The discount amount is INR " + discountAmount + " and final discounted fee is INR " + finalFee); }}}