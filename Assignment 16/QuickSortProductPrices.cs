using System;

namespace SortingAssignment
{
    class QuickSortProductPrices
    {
        static void Main()
        {
            // Declare the array to store product prices
            double[] productPrices;

            // Get the number of products
            Console.Write("Enter the number of products: ");
            int numberOfProducts = Convert.ToInt32(Console.ReadLine());

            // Validate input
            if (numberOfProducts <= 0)
            {
                Console.WriteLine("Invalid number of products. Exiting program.");
                return;
            }

            // Initialize the array
            productPrices = new double[numberOfProducts];

            // Get product prices from user
            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.Write($"Enter price of product {i + 1}: ");
                productPrices[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Perform Quick Sort
            QuickSort(productPrices, 0, productPrices.Length - 1);

            // Display sorted product prices
            Console.WriteLine("\nSorted Product Prices in Ascending Order:");
            for (int i = 0; i < productPrices.Length; i++)
            {
                Console.Write(productPrices[i] + " ");
            }
            Console.WriteLine();
        }

        // Quick Sort function
        static void QuickSort(double[] arr, int low, int high)
        {
            if (low < high)
            {
                // Partition the array and get pivot index
                int pivotIndex = Partition(arr, low, high);

                // Recursively sort elements before and after partition
                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        // Partition function
        static int Partition(double[] arr, int low, int high)
        {
            double pivot = arr[high]; // Choose the last element as pivot
            int i = low - 1; // Index for smaller elements

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    // Swap arr[i] and arr[j]
                    double temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Swap pivot element with the element at i+1 to place pivot in correct position
            double tempPivot = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = tempPivot;

            return i + 1; // Return pivot index
        }
    }
}
