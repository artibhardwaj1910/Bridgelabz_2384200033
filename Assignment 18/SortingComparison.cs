using System;
using System.Diagnostics;
namespace TimeNSpaceAssignment
{
    class SortingComparison
    {
        // Generate random dataset
        static int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, size * 10);
            }
            return array;
        }

        // Bubble Sort (O(N²))
        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        // Merge Sort (O(N log N))
        static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);
                Merge(array, left, mid, right);
            }
        }

        static void Merge(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArr[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                rightArr[j] = array[mid + 1 + j];

            int iIndex = 0, jIndex = 0, kIndex = left;
            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArr[iIndex] <= rightArr[jIndex])
                    array[kIndex++] = leftArr[iIndex++];
                else
                    array[kIndex++] = rightArr[jIndex++];
            }

            while (iIndex < n1)
                array[kIndex++] = leftArr[iIndex++];
            while (jIndex < n2)
                array[kIndex++] = rightArr[jIndex++];
        }

        // Quick Sort (O(N log N))
        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(array, low, high);
                QuickSort(array, low, pivot - 1);
                QuickSort(array, pivot + 1, high);
            }
        }

        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int tempPivot = array[i + 1];
            array[i + 1] = array[high];
            array[high] = tempPivot;

            return i + 1;
        }

        static void Main()
        {
            int[] sizes = { 1000, 10000, 1000000 };

            foreach (int size in sizes)
            {
                Console.WriteLine($"Dataset Size: {size}");

                int[] data;

                // Bubble Sort Timing (Only for small N)
                if (size <= 10000)
                {
                    data = GenerateRandomArray(size);
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    BubbleSort(data);
                    stopwatch.Stop();
                    Console.WriteLine($"Bubble Sort | N={size} | Time={stopwatch.ElapsedMilliseconds} ms");
                }
                else
                {
                    Console.WriteLine($"Bubble Sort | N={size} | Skipped (Too Slow)");
                }

                // Merge Sort Timing
                data = GenerateRandomArray(size);
                Stopwatch mergeStopwatch = Stopwatch.StartNew();
                MergeSort(data, 0, data.Length - 1);
                mergeStopwatch.Stop();
                Console.WriteLine($"Merge Sort  | N={size} | Time={mergeStopwatch.ElapsedMilliseconds} ms");

                // Quick Sort Timing
                data = GenerateRandomArray(size);
                Stopwatch quickStopwatch = Stopwatch.StartNew();
                QuickSort(data, 0, data.Length - 1);
                quickStopwatch.Stop();
                Console.WriteLine($"Quick Sort  | N={size} | Time={quickStopwatch.ElapsedMilliseconds} ms\n");
            }
        }
    }
}
