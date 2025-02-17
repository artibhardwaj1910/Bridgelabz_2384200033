using System;

namespace SortingAssignment
{
    class HeapSortJobApplicants
    {
        static void Main()
        {
            // Declare the array to store salary demands
            double[] salaryDemands;

            // Get the number of applicants
            Console.Write("Enter the number of job applicants: ");
            int numberOfApplicants = Convert.ToInt32(Console.ReadLine());

            // Validate input
            if (numberOfApplicants <= 0)
            {
                Console.WriteLine("Invalid number of applicants. Exiting program.");
                return;
            }

            // Initialize the array
            salaryDemands = new double[numberOfApplicants];

            // Get salary demands from user
            for (int i = 0; i < numberOfApplicants; i++)
            {
                Console.Write($"Enter expected salary for applicant {i + 1}: ");
                salaryDemands[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Perform Heap Sort
            HeapSort(salaryDemands);

            // Display sorted salary demands
            Console.WriteLine("\nSorted Salary Demands in Ascending Order:");
            for (int i = 0; i < salaryDemands.Length; i++)
            {
                Console.Write(salaryDemands[i] + " ");
            }
            Console.WriteLine();
        }

        // Heap Sort function
        static void HeapSort(double[] arr)
        {
            int n = arr.Length;

            // Build a Max Heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            // Extract elements one by one
            for (int i = n - 1; i > 0; i--)
            {
                // Swap root (largest) with last element
                double temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // Reheapify the reduced heap
                Heapify(arr, i, 0);
            }
        }

        // Heapify function to maintain Max Heap property
        static void Heapify(double[] arr, int n, int i)
        {
            int largest = i; // Initialize root as largest
            int left = 2 * i + 1; // Left child
            int right = 2 * i + 2; // Right child

            // Check if left child is larger than root
            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            // Check if right child is larger than largest so far
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            // If largest is not root, swap and recursively heapify the affected sub-tree
            if (largest != i)
            {
                double temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                Heapify(arr, n, largest);
            }
        }
    }
}
