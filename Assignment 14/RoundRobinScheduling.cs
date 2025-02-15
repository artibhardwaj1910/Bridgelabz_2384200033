using System;
namespace RoundRobinScheduling
{
    // Class representing a Process Node in the Circular Linked List
    class ProcessNode
    {
        public int ProcessID;
        public int BurstTime;
        public int Priority;
        public int RemainingTime;
        public ProcessNode Next;

        public ProcessNode(int processID, int burstTime, int priority)
        {
            ProcessID = processID;
            BurstTime = burstTime;
            Priority = priority;
            RemainingTime = burstTime;
            Next = this; // Circular reference
        }
    }

    // Class to manage the Round Robin Scheduling using Circular Linked List
    class RoundRobinScheduler
    {
        private ProcessNode head;
        private int timeQuantum;

        public RoundRobinScheduler(int quantum)
        {
            timeQuantum = quantum;
        }

        // Add Process at the End
        public void AddProcess(int processID, int burstTime, int priority)
        {
            ProcessNode newNode = new ProcessNode(processID, burstTime, priority);
            if (head == null)
            {
                head = newNode;
                head.Next = head;
                return;
            }

            ProcessNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Next = head;
        }

        // Remove Process by Process ID after execution
        public void RemoveProcess(int processID)
        {
            if (head == null)
            {
                Console.WriteLine("No Processes Available!");
                return;
            }

            ProcessNode temp = head, prev = null;
            do
            {
                if (temp.ProcessID == processID)
                {
                    if (temp == head)
                    {
                        ProcessNode last = head;
                        while (last.Next != head)
                        {
                            last = last.Next;
                        }

                        head = head.Next;
                        last.Next = head;
                    }
                    else
                    {
                        prev.Next = temp.Next;
                    }

                    Console.WriteLine($"Process {processID} Completed and Removed.");
                    return;
                }

                prev = temp;
                temp = temp.Next;
            } while (temp != head);
        }

        // Simulate Round Robin Scheduling
        public void ExecuteScheduling()
        {
            if (head == null)
            {
                Console.WriteLine("No Processes to Execute!");
                return;
            }

            int currentTime = 0;
            int totalProcesses = 0;
            int totalWaitingTime = 0;
            int totalTurnaroundTime = 0;

            ProcessNode current = head;
            do
            {
                totalProcesses++;
                current = current.Next;
            } while (current != head);

            while (head != null)
            {
                Console.WriteLine($"\nTime: {currentTime}");
                DisplayProcesses();

                ProcessNode temp = head;
                do
                {
                    if (temp.RemainingTime > 0)
                    {
                        int executionTime = Math.Min(timeQuantum, temp.RemainingTime);
                        temp.RemainingTime -= executionTime;
                        currentTime += executionTime;

                        if (temp.RemainingTime == 0)
                        {
                            int turnaroundTime = currentTime;
                            int waitingTime = turnaroundTime - temp.BurstTime;

                            totalTurnaroundTime += turnaroundTime;
                            totalWaitingTime += waitingTime;

                            int processID = temp.ProcessID;
                            temp = temp.Next;
                            RemoveProcess(processID);
                        }
                        else
                        {
                            temp = temp.Next;
                        }
                    }
                    else
                    {
                        temp = temp.Next;
                    }

                } while (temp != head && head != null);
            }

            // Calculate and Display Averages
            double avgWaitingTime = (double)totalWaitingTime / totalProcesses;
            double avgTurnaroundTime = (double)totalTurnaroundTime / totalProcesses;

            Console.WriteLine($"\nAverage Waiting Time: {avgWaitingTime:F2}");
            Console.WriteLine($"Average Turnaround Time: {avgTurnaroundTime:F2}");
        }

        // Display All Processes
        public void DisplayProcesses()
        {
            if (head == null)
            {
                Console.WriteLine("No Processes Available!");
                return;
            }

            ProcessNode temp = head;
            do
            {
                Console.WriteLine($"Process ID: {temp.ProcessID}, Burst Time: {temp.BurstTime}, Priority: {temp.Priority}, Remaining Time: {temp.RemainingTime}");
                temp = temp.Next;
            } while (temp != head);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Time Quantum: ");
            int timeQuantum = Convert.ToInt32(Console.ReadLine());

            RoundRobinScheduler scheduler = new RoundRobinScheduler(timeQuantum);

            while (true)
            {
                Console.WriteLine("\nRound Robin Scheduling");
                Console.WriteLine("1. Add Process");
                Console.WriteLine("2. Execute Scheduling");
                Console.WriteLine("3. Display Processes");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 4)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                int processID, burstTime, priority;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Process ID: ");
                        processID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Burst Time: ");
                        burstTime = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Priority: ");
                        priority = Convert.ToInt32(Console.ReadLine());
                        scheduler.AddProcess(processID, burstTime, priority);
                        break;

                    case 2:
                        scheduler.ExecuteScheduling();
                        break;

                    case 3:
                        scheduler.DisplayProcesses();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice! Try Again.");
                        break;
                }
            }
        }
    }
}
