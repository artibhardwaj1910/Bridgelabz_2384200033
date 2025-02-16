using System;
namespace QueueUsingStacks
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

        // Check if stack is empty
        public bool IsEmpty()
        {
            return top == null;
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
    }

    // Queue Implementation Using Two Stacks
    class QueueUsingTwoStacks
    {
        private Stack stackEnqueue; // Used for enqueue operations
        private Stack stackDequeue; // Used for dequeue operations

        public QueueUsingTwoStacks()
        {
            stackEnqueue = new Stack();
            stackDequeue = new Stack();
        }

        // Enqueue Operation
        public void Enqueue(int data)
        {
            stackEnqueue.Push(data);
            Console.WriteLine($"Enqueued: {data}");
        }

        // Dequeue Operation
        public int Dequeue()
        {
            if (stackDequeue.IsEmpty())
            {
                while (!stackEnqueue.IsEmpty())
                {
                    stackDequeue.Push(stackEnqueue.Pop());
                }
            }

            if (stackDequeue.IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }

            return stackDequeue.Pop();
        }

        // Display queue elements
        public void Display()
        {
            if (stackEnqueue.IsEmpty() && stackDequeue.IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return;
            }

            Stack tempStack = new Stack();
            while (!stackDequeue.IsEmpty())
            {
                tempStack.Push(stackDequeue.Pop());
            }

            while (!stackEnqueue.IsEmpty())
            {
                tempStack.Push(stackEnqueue.Pop());
            }

            Console.Write("Queue Elements: ");
            while (!tempStack.IsEmpty())
            {
                int val = tempStack.Pop();
                Console.Write(val + " ");
                stackEnqueue.Push(val);
            }

            while (!stackEnqueue.IsEmpty())
            {
                stackDequeue.Push(stackEnqueue.Pop());
            }

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            QueueUsingTwoStacks queue = new QueueUsingTwoStacks();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Display(); // Should display: 10 20 30

            Console.WriteLine($"Dequeued: {queue.Dequeue()}"); // Should return 10
            queue.Display(); // Should display: 20 30

            queue.Enqueue(40);
            queue.Display(); // Should display: 20 30 40

            Console.WriteLine($"Dequeued: {queue.Dequeue()}"); // Should return 20
            queue.Display(); // Should display: 30 40
        }
    }
}

