using System;

namespace SortingAssignment
{
    class InsertionSortEmployeeIDs
    {
        static void Main()
        {
            // Declare the array to store employee IDs
            int[] employeeIDs;

            // Get the number of employees
            Console.Write("Enter the number of employees: ");
            int numberOfEmployees = Convert.ToInt32(Console.ReadLine());

            // Validate input
            if (numberOfEmployees <= 0)
            {
                Console.WriteLine("Invalid number of employees. Exiting program.");
                return;
            }

            // Initialize the array
            employeeIDs = new int[numberOfEmployees];

            // Get employee IDs from user
            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.Write($"Enter Employee ID {i + 1}: ");
                employeeIDs[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Perform Insertion Sort
            for (int i = 1; i < employeeIDs.Length; i++)
            {
                int key = employeeIDs[i]; // Element to be inserted in sorted part
                int j = i - 1;

                // Shift elements to the right to create correct position for key
                while (j >= 0 && employeeIDs[j] > key)
                {
                    employeeIDs[j + 1] = employeeIDs[j];
                    j--;
                }

                // Insert the key in its correct position
                employeeIDs[j + 1] = key;
            }

            // Display sorted employee IDs
            Console.WriteLine("\nSorted Employee IDs in Ascending Order:");
            for (int i = 0; i < employeeIDs.Length; i++)
            {
                Console.Write(employeeIDs[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
