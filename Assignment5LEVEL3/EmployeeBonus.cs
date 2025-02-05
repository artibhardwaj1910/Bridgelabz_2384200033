using System;

namespace Assignment05Level3
{
    public class EmployeeBonus
    {
        // Method to determine the salary and years of service for 10 employees
        public static int[,] GenerateEmployeeData(int employeeCount)
        {
            Random random = new Random();
            int[,] employeeData = new int[employeeCount, 2]; // [Employee][0=Salary, 1=Years of Service]

            for (int i = 0; i < employeeCount; i++)
            {
                employeeData[i, 0] = random.Next(20000, 100000); // Generate random salary (5-digit)
                employeeData[i, 1] = random.Next(1, 11);         // Generate random years of service (1 to 10)
            }

            return employeeData;
        }

        // Method to calculate new salary and bonus for employees
        public static double[,] CalculateNewSalaryAndBonus(int[,] employeeData)
        {
            int employeeCount = employeeData.GetLength(0);
            double[,] updatedData = new double[employeeCount, 2]; // [Employee][0=New Salary, 1=Bonus Amount]

            for (int i = 0; i < employeeCount; i++)
            {
                int salary = employeeData[i, 0];
                int yearsOfService = employeeData[i, 1];

                double bonusPercentage = yearsOfService > 5 ? 0.05 : 0.02; // Bonus logic
                double bonusAmount = salary * bonusPercentage;
                double newSalary = salary + bonusAmount;

                updatedData[i, 0] = newSalary;
                updatedData[i, 1] = bonusAmount;
            }

            return updatedData;
        }

        // Method to calculate and display the total bonus, old salary sum, and new salary sum
        public static void DisplaySummary(int[,] employeeData, double[,] updatedData)
        {
            double totalOldSalary = 0;
            double totalNewSalary = 0;
            double totalBonus = 0;

            Console.WriteLine("{0,-10} {1,-12} {2,-15} {3,-12} {4,-12} {5,-12}", "Employee", "Old Salary", "Years of Service", "Bonus", "New Salary", "Total Bonus");
            Console.WriteLine(new string('-', 75));

            for (int i = 0; i < employeeData.GetLength(0); i++)
            {
                int oldSalary = employeeData[i, 0];
                int yearsOfService = employeeData[i, 1];
                double bonus = updatedData[i, 1];
                double newSalary = updatedData[i, 0];

                totalOldSalary += oldSalary;
                totalNewSalary += newSalary;
                totalBonus += bonus;

                Console.WriteLine("{0,-10} {1,-12:F2} {2,-15} {3,-12:F2} {4,-12:F2} {5,-12:F2}", 
                                  i + 1, oldSalary, yearsOfService, bonus, newSalary, totalBonus);
            }

            Console.WriteLine(new string('-', 75));
            Console.WriteLine("Total Old Salary: {0:F2}", totalOldSalary);
            Console.WriteLine("Total New Salary: {0:F2}", totalNewSalary);
            Console.WriteLine("Total Bonus Amount: {0:F2}", totalBonus);
        }

        public static void Main(string[] args)
        {
            int employeeCount = 10;

            // Step 1: Generate random employee data
            int[,] employeeData = GenerateEmployeeData(employeeCount);

            // Step 2: Calculate new salary and bonus
            double[,] updatedData = CalculateNewSalaryAndBonus(employeeData);

            // Step 3: Display summary
            DisplaySummary(employeeData, updatedData);
        }
    }
}

