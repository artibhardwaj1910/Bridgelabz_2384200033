using System;
namespace TaskScheduler
{
    // Class representing a Task Node in the Circular Linked List
    class TaskNode
    {
        public int TaskID;
        public string TaskName;
        public int Priority;
        public DateTime DueDate;
        public TaskNode Next;

        public TaskNode(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskID = taskId;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
            Next = this; // Circular reference
        }
    }

    // Class to manage the Circular Linked List for Task Scheduling
    class TaskCircularLinkedList
    {
        private TaskNode head;
        private TaskNode currentTask;

        // Add Task at the Beginning
        public void AddAtBeginning(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(taskId, taskName, priority, dueDate);
            if (head == null)
            {
                head = newNode;
                head.Next = head;
                currentTask = head;
                return;
            }

            TaskNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Next = head;
            head = newNode;
        }

        // Add Task at the End
        public void AddAtEnd(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(taskId, taskName, priority, dueDate);
            if (head == null)
            {
                head = newNode;
                head.Next = head;
                currentTask = head;
                return;
            }

            TaskNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Next = head;
        }

        // Add Task at a Specific Position
        public void AddAtPosition(int taskId, string taskName, int priority, DateTime dueDate, int position)
        {
            TaskNode newNode = new TaskNode(taskId, taskName, priority, dueDate);
            if (position == 1)
            {
                AddAtBeginning(taskId, taskName, priority, dueDate);
                return;
            }

            TaskNode temp = head;
            for (int i = 1; temp.Next != head && i < position - 1; i++)
            {
                temp = temp.Next;
            }

            if (temp.Next == head && position > 1)
            {
                Console.WriteLine("Invalid Position!");
                return;
            }

            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        // Remove Task by Task ID
        public void RemoveByTaskID(int taskId)
        {
            if (head == null)
            {
                Console.WriteLine("No Tasks Available!");
                return;
            }

            TaskNode temp = head, prev = null;

            do
            {
                if (temp.TaskID == taskId)
                {
                    if (temp == head)
                    {
                        TaskNode last = head;
                        while (last.Next != head)
                        {
                            last = last.Next;
                        }

                        head = head.Next;
                        last.Next = head;
                        if (temp == currentTask)
                        {
                            currentTask = head;
                        }
                    }
                    else
                    {
                        prev.Next = temp.Next;
                        if (temp == currentTask)
                        {
                            currentTask = prev.Next;
                        }
                    }

                    Console.WriteLine("Task Removed!");
                    return;
                }

                prev = temp;
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine("Task Not Found!");
        }

        // View Current Task and Move to the Next Task
        public void ViewCurrentTask()
        {
            if (currentTask == null)
            {
                Console.WriteLine("No Tasks Available!");
                return;
            }

            Console.WriteLine($"Current Task: ID={currentTask.TaskID}, Name={currentTask.TaskName}, Priority={currentTask.Priority}, DueDate={currentTask.DueDate}");
            currentTask = currentTask.Next;
        }

        // Display All Tasks
        public void DisplayAllTasks()
        {
            if (head == null)
            {
                Console.WriteLine("No Tasks Available!");
                return;
            }

            TaskNode temp = head;
            do
            {
                Console.WriteLine($"ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, DueDate: {temp.DueDate}");
                temp = temp.Next;
            } while (temp != head);
        }

        // Search Task by Priority
        public void SearchByPriority(int priority)
        {
            if (head == null)
            {
                Console.WriteLine("No Tasks Available!");
                return;
            }

            TaskNode temp = head;
            bool found = false;
            do
            {
                if (temp.Priority == priority)
                {
                    Console.WriteLine($"ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, DueDate: {temp.DueDate}");
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
            {
                Console.WriteLine("No Tasks Found with the Given Priority!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TaskCircularLinkedList taskList = new TaskCircularLinkedList();

            while (true)
            {
                Console.WriteLine("\nTask Scheduler");
                Console.WriteLine("1. Add at Beginning");
                Console.WriteLine("2. Add at End");
                Console.WriteLine("3. Add at Position");
                Console.WriteLine("4. Remove by Task ID");
                Console.WriteLine("5. View Current Task");
                Console.WriteLine("6. Display All Tasks");
                Console.WriteLine("7. Search by Priority");
                Console.WriteLine("8. Exit");
                Console.Write("Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 8)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                int taskId, priority, position;
                string taskName;
                DateTime dueDate;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Task ID: ");
                        taskId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Task Name: ");
                        taskName = Console.ReadLine();
                        Console.Write("Enter Priority: ");
                        priority = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Due Date (yyyy-mm-dd): ");
                        dueDate = Convert.ToDateTime(Console.ReadLine());
                        taskList.AddAtBeginning(taskId, taskName, priority, dueDate);
                        break;

                    case 2:
                        Console.Write("Enter Task ID: ");
                        taskId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Task Name: ");
                        taskName = Console.ReadLine();
                        Console.Write("Enter Priority: ");
                        priority = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Due Date (yyyy-mm-dd): ");
                        dueDate = Convert.ToDateTime(Console.ReadLine());
                        taskList.AddAtEnd(taskId, taskName, priority, dueDate);
                        break;

                    case 3:
                        Console.Write("Enter Task ID: ");
                        taskId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Task Name: ");
                        taskName = Console.ReadLine();
                        Console.Write("Enter Priority: ");
                        priority = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Due Date (yyyy-mm-dd): ");
                        dueDate = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Enter Position: ");
                        position = Convert.ToInt32(Console.ReadLine());
                        taskList.AddAtPosition(taskId, taskName, priority, dueDate, position);
                        break;

                    case 4:
                        Console.Write("Enter Task ID to Remove: ");
                        taskId = Convert.ToInt32(Console.ReadLine());
                        taskList.RemoveByTaskID(taskId);
                        break;

                    case 5:
                        taskList.ViewCurrentTask();
                        break;

                    case 6:
                        taskList.DisplayAllTasks();
                        break;

                    case 7:
                        Console.Write("Enter Priority to Search: ");
                        priority = Convert.ToInt32(Console.ReadLine());
                        taskList.SearchByPriority(priority);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice! Try Again.");
                        break;
                }
            }
        }
    }
}
