using System;

namespace SortingAssignment
{
    class MergeSortBookPrices
    {
        static void Main()
        {
            // Declare the array to store book prices
            double[] bookPrices;

            // Get the number of books
            Console.Write("Enter the number of books: ");
            int numberOfBooks = Convert.ToInt32(Console.ReadLine());

            // Validate input
            if (numberOfBooks <= 0)
            {
                Console.WriteLine("Invalid number of books. Exiting program.");
                return;
            }

            // Initialize the array
            bookPrices = new double[numberOfBooks];

            // Get book prices from user
            for (int i = 0; i < numberOfBooks; i++)
            {
                Console.Write($"Enter price of book {i + 1}: ");
                bookPrices[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Perform Merge Sort
            MergeSort(bookPrices, 0, bookPrices.Length - 1);

            // Display sorted book prices
            Console.WriteLine("\nSorted Book Prices in Ascending Order:");
            for (int i = 0; i < bookPrices.Length; i++)
            {
                Console.Write(bookPrices[i] + " ");
            }
            Console.WriteLine();
        }

        // Merge Sort function
        static void MergeSort(double[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                // Recursively sort the left and right halves
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);

                // Merge the sorted halves
                Merge(arr, left, mid, right);
            }
        }

        // Merge function
        static void Merge(double[] arr, int left, int mid, int right)
        {
            int leftSize = mid - left + 1;
            int rightSize = right - mid;

            // Temporary arrays
            double[] leftArr = new double[leftSize];
            double[] rightArr = new double[rightSize];

            // Copy data to temporary arrays
            for (int i = 0; i < leftSize; i++)
                leftArr[i] = arr[left + i];

            for (int j = 0; j < rightSize; j++)
                rightArr[j] = arr[mid + 1 + j];

            // Merge the two sorted arrays
            int iLeft = 0, iRight = 0, iMerge = left;
            while (iLeft < leftSize && iRight < rightSize)
            {
                if (leftArr[iLeft] <= rightArr[iRight])
                {
                    arr[iMerge] = leftArr[iLeft];
                    iLeft++;
                }
                else
                {
                    arr[iMerge] = rightArr[iRight];
                    iRight++;
                }
                iMerge++;
            }

            // Copy remaining elements from leftArr
            while (iLeft < leftSize)
            {
                arr[iMerge] = leftArr[iLeft];
                iLeft++;
                iMerge++;
            }

            // Copy remaining elements from rightArr
            while (iRight < rightSize)
            {
                arr[iMerge] = rightArr[iRight];
                iRight++;
                iMerge++;
            }
        }
    }
}
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
