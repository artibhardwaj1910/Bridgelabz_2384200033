using System;
using System.Collections;
using System.Collections.Generic;
namespace CollectionsAssignment
{
    class ReverseList
    {
        // Method to reverse an ArrayList without using built-in methods
        static void ReverseArrayList(ArrayList list)
        {
            int left = 0, right = list.Count - 1;
            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }

        // Method to reverse a LinkedList without using built-in methods
        static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
        {
            LinkedList<int> reversedList = new LinkedList<int>();
            foreach (int item in list)
            {
                reversedList.AddFirst(item); // Insert each element at the beginning
            }
            return reversedList;
        }

        static void Main()
        {
            // Using ArrayList
            ArrayList numbersArrayList = new ArrayList { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original ArrayList: " + string.Join(", ", numbersArrayList.ToArray()));

            ReverseArrayList(numbersArrayList);
            Console.WriteLine("Reversed ArrayList: " + string.Join(", ", numbersArrayList.ToArray()));

            // Using LinkedList
            LinkedList<int> numbersLinkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("\nOriginal LinkedList: " + string.Join(", ", numbersLinkedList));

            numbersLinkedList = ReverseLinkedList(numbersLinkedList);
            Console.WriteLine("Reversed LinkedList: " + string.Join(", ", numbersLinkedList));
        }
    }
}

