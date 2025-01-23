using System;
class BonusOfEmployees{
    static void Main(string[] args){
        double salary;
        int yearsOfService;

        // For user input
        Console.Write("Enter salary: ");
        salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter years of service: ");
        yearsOfService = Convert.ToInt32(Console.ReadLine());

        if (yearsOfService > 5){
            double bonus = salary * 0.05;
            Console.WriteLine("Bonus is: " + bonus);}
        else{
            Console.WriteLine("No bonus.");
 }}}