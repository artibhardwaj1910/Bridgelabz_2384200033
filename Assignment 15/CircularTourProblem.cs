using System;
namespace CircularTourProblem
{
    class Node
    {
        public int petrol;
        public int distance;
        public Node next;

        public Node(int petrol, int distance)
        {
            this.petrol = petrol;
            this.distance = distance;
            this.next = null;
        }
    }

    class Queue
    {
        private Node front;
        private Node rear;

        public Queue()
        {
            front = rear = null;
        }

        public void Enqueue(int petrol, int distance)
        {
            Node newNode = new Node(petrol, distance);
            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
        }

        public Node GetFront()
        {
            return front;
        }

        public void Dequeue()
        {
            if (front == null) return;
            front = front.next;
            if (front == null)
                rear = null;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }

    class CircularTour
    {
        public static int FindStartingPump(int[] petrol, int[] distance)
        {
            int n = petrol.Length;
            int totalPetrol = 0, totalDistance = 0, startIndex = 0, surplusPetrol = 0;

            for (int i = 0; i < n; i++)
            {
                totalPetrol += petrol[i];
                totalDistance += distance[i];
                surplusPetrol += petrol[i] - distance[i];

                if (surplusPetrol < 0)
                {
                    startIndex = i + 1;
                    surplusPetrol = 0;
                }
            }

            return totalPetrol >= totalDistance ? startIndex : -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] petrol = { 4, 6, 7, 4 };
            int[] distance = { 6, 5, 3, 5 };

            int startingPoint = CircularTour.FindStartingPump(petrol, distance);

            if (startingPoint == -1)
                Console.WriteLine("Tour not possible.");
            else
                Console.WriteLine("Start at Petrol Pump: " + startingPoint);
        }
    }
}

