using System;
namespace Program{
    class CalculateFee{
        public static void Main(string[] args){
            // Declare variables
            double fee;
            double discountPercent;

            // For user input
            Console.WriteLine("Enter the Student Fee (in INR):");
            fee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the University Discount Percentage:");
            discountPercent = Convert.ToDouble(Console.ReadLine());

            // Calculate discountAmount
            double discountAmount = (fee * discountPercent) / 100.0;

            // Calculate finalFee after deducting
            double finalFee = fee - discountAmount;

            // Display the result
            Console.WriteLine($"The discount amount is INR {discountAmount} and the final discounted fee is INR {finalFee}");
}}}