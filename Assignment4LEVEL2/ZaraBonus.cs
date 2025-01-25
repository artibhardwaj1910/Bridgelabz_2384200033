using System;
class ZaraBonus{
    static void Main(){
        // Define arrays for storing
        double[] salary = new double[10];
        double[] yearsOfService = new double[10];
        double[] newSalary = new double[10];
        double[] bonus = new double[10];

        // Define variables
        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        // Loop to take input from the user for salary and years of service
        for (int i = 0; i < 10; i++){
            Console.WriteLine($"Enter details for employee {i + 1}:");

            // Input for salary and years of service
            while (true){
                Console.Write("Enter salary: ");
                if (double.TryParse(Console.ReadLine(), out salary[i]) && salary[i] > 0)
                    break;
                else
                    Console.WriteLine("Invalid salary. Please enter a positive number.");}

            while (true){
                Console.Write("Enter years of service: ");
                if (double.TryParse(Console.ReadLine(), out yearsOfService[i]) && yearsOfService[i] >= 0)
                    break;
                else
                    Console.WriteLine("Invalid years of service. Please enter a non-negative number.");}

            // If salary or years of service is invalid
            if (salary[i] <= 0 || yearsOfService[i] < 0){
                i--;
                continue; }}

        // Calculate bonus, new salary, and total payouts
        for (int i = 0; i < 10; i++){
            // Calculate bonus based on years of service
            if (yearsOfService[i] > 5)
                bonus[i] = salary[i] * 0.05;
            else
                bonus[i] = salary[i] * 0.02;

            newSalary[i] = salary[i] + bonus[i];

            // Update total bonus, old salary, and new salary
            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];}

        // Display total bonus, total old salary, and total new salary
        Console.WriteLine($"\nTotal Bonus Payout: {totalBonus:C}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary:C}");
        Console.WriteLine($"Total New Salary (including bonus): {totalNewSalary:C}"); }}