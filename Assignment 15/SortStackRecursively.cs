using System;
namespace SortStackRecursively
{
    // Node class for Stack
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    // Stack Implementation Using Linked List
    class Stack
    {
        private Node top;

        public Stack()
        {
            top = null;
        }

        // Push operation
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = top;
            top = newNode;
        }

        // Pop operation
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            int value = top.data;
            top = top.next;
            return value;
        }

        // Peek operation
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            return top.data;
        }

        // Check if stack is empty
        public bool IsEmpty()
        {
            return top == null;
        }

        // Display stack elements
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return;
            }

            Node temp = top;
            Console.Write("Stack Elements: ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        // Recursive function to sort the stack
        public void SortStack()
        {
            if (!IsEmpty())
            {
                int temp = Pop();
                SortStack();
                InsertSorted(temp);
            }
        }

        // Helper function to insert an element in sorted order
        private void InsertSorted(int value)
        {
            if (IsEmpty() || Peek() <= value)
            {
                Push(value);
                return;
            }

            int temp = Pop();
            InsertSorted(value);
            Push(temp);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(30);
            stack.Push(10);
            stack.Push(50);
            stack.Push(20);
            stack.Push(40);

            Console.WriteLine("Original Stack:");
            stack.Display();

            stack.SortStack();

            Console.WriteLine("Sorted Stack:");
            stack.Display();
        }
    }
}

