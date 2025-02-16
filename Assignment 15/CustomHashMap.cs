using System;
namespace CustomHashMap
{
    class HashNode
    {
        public int key;
        public int value;
        public HashNode next;

        public HashNode(int key, int value)
        {
            this.key = key;
            this.value = value;
            this.next = null;
        }
    }

    class CustomHashMap
    {
        private int capacity;
        private HashNode[] bucketArray;

        public CustomHashMap(int size)
        {
            capacity = size;
            bucketArray = new HashNode[capacity];
        }

        // Hash Function
        private int GetHashIndex(int key)
        {
            return key % capacity;
        }

        // Insert or Update Key-Value Pair
        public void Put(int key, int value)
        {
            int index = GetHashIndex(key);
            HashNode head = bucketArray[index];

            // Update if key exists
            while (head != null)
            {
                if (head.key == key)
                {
                    head.value = value;
                    return;
                }
                head = head.next;
            }

            // Insert at beginning (Separate Chaining)
            HashNode newNode = new HashNode(key, value);
            newNode.next = bucketArray[index];
            bucketArray[index] = newNode;
        }

        // Retrieve Value by Key
        public int Get(int key)
        {
            int index = GetHashIndex(key);
            HashNode head = bucketArray[index];

            while (head != null)
            {
                if (head.key == key)
                    return head.value;
                head = head.next;
            }

            return -1; // Key not found
        }

        // Remove Key-Value Pair
        public void Remove(int key)
        {
            int index = GetHashIndex(key);
            HashNode head = bucketArray[index];
            HashNode prev = null;

            while (head != null)
            {
                if (head.key == key)
                {
                    if (prev == null)
                        bucketArray[index] = head.next;
                    else
                        prev.next = head.next;

                    return;
                }

                prev = head;
                head = head.next;
            }
        }

        // Display Hash Map Contents
        public void Display()
        {
            for (int i = 0; i < capacity; i++)
            {
                Console.Write($"Bucket {i}: ");
                HashNode head = bucketArray[i];

                while (head != null)
                {
                    Console.Write($"[{head.key}, {head.value}] -> ");
                    head = head.next;
                }

                Console.WriteLine("NULL");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CustomHashMap hashMap = new CustomHashMap(5);
            
            hashMap.Put(1, 10);
            hashMap.Put(2, 20);
            hashMap.Put(6, 60); // Collision: 6 % 5 = 1
            hashMap.Put(11, 110); // Collision: 11 % 5 = 1
            hashMap.Display();

            Console.WriteLine($"Get Key 2: {hashMap.Get(2)}"); // Should return 20
            Console.WriteLine($"Get Key 6: {hashMap.Get(6)}"); // Should return 60

            hashMap.Remove(6);
            Console.WriteLine("After Removing Key 6:");
            hashMap.Display();
        }
    }
}

