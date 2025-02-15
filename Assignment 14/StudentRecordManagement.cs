using System;
namespace StudentRecordManagement
{
    // Class to represent a Student Node
    class StudentNode
    {
        public int RollNumber;
        public string Name;
        public int Age;
        public char Grade;
        public StudentNode Next;

        public StudentNode(int rollNumber, string name, int age, char grade)
        {
            RollNumber = rollNumber;
            Name = name;
            Age = age;
            Grade = grade;
            Next = null;
        }
    }

    // Class to manage the Student Record List
    class StudentLinkedList
    {
        private StudentNode head;

        // Add Student at the Beginning
        public void AddAtBeginning(int rollNumber, string name, int age, char grade)
        {
            StudentNode newNode = new StudentNode(rollNumber, name, age, grade);
            newNode.Next = head;
            head = newNode;
        }

        // Add Student at the End
        public void AddAtEnd(int rollNumber, string name, int age, char grade)
        {
            StudentNode newNode = new StudentNode(rollNumber, name, age, grade);
            if (head == null)
            {
                head = newNode;
                return;
            }

            StudentNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        // Add Student at a Specific Position
        public void AddAtPosition(int rollNumber, string name, int age, char grade, int position)
        {
            StudentNode newNode = new StudentNode(rollNumber, name, age, grade);
            if (position == 1)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            StudentNode temp = head;
            for (int i = 1; temp != null && i < position - 1; i++)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Invalid Position!");
                return;
            }

            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        // Delete Student by Roll Number
        public void DeleteByRollNumber(int rollNumber)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty!");
                return;
            }

            if (head.RollNumber == rollNumber)
            {
                head = head.Next;
                Console.WriteLine("Student Record Deleted!");
                return;
            }

            StudentNode temp = head, prev = null;
            while (temp != null && temp.RollNumber != rollNumber)
            {
                prev = temp;
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Student Record Not Found!");
                return;
            }

            prev.Next = temp.Next;
            Console.WriteLine("Student Record Deleted!");
        }

        // Search Student by Roll Number
        public void SearchByRollNumber(int rollNumber)
        {
            StudentNode temp = head;
            while (temp != null)
            {
                if (temp.RollNumber == rollNumber)
                {
                    Console.WriteLine($"Student Found: Roll No: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student Record Not Found!");
        }

        // Display All Student Records
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No Student Records Available!");
                return;
            }

            StudentNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"Roll No: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                temp = temp.Next;
            }
        }

        // Update Student Grade by Roll Number
        public void UpdateGrade(int rollNumber, char newGrade)
        {
            StudentNode temp = head;
            while (temp != null)
            {
                if (temp.RollNumber == rollNumber)
                {
                    temp.Grade = newGrade;
                    Console.WriteLine("Student Grade Updated!");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student Record Not Found!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentLinkedList studentList = new StudentLinkedList();

            while (true)
            {
                Console.WriteLine("\nStudent Record Management");
                Console.WriteLine("1. Add at Beginning");
                Console.WriteLine("2. Add at End");
                Console.WriteLine("3. Add at Position");
                Console.WriteLine("4. Delete by Roll Number");
                Console.WriteLine("5. Search by Roll Number");
                Console.WriteLine("6. Display All");
                Console.WriteLine("7. Update Grade");
                Console.WriteLine("8. Exit");
                Console.Write("Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 8)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                int rollNumber, age, position;
                string name;
                char grade;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Roll Number: ");
                        rollNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Grade: ");
                        grade = Convert.ToChar(Console.ReadLine());
                        studentList.AddAtBeginning(rollNumber, name, age, grade);
                        break;

                    case 2:
                        Console.Write("Enter Roll Number: ");
                        rollNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Grade: ");
                        grade = Convert.ToChar(Console.ReadLine());
                        studentList.AddAtEnd(rollNumber, name, age, grade);
                        break;

                    case 3:
                        Console.Write("Enter Roll Number: ");
                        rollNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Grade: ");
                        grade = Convert.ToChar(Console.ReadLine());
                        Console.Write("Enter Position: ");
                        position = Convert.ToInt32(Console.ReadLine());
                        studentList.AddAtPosition(rollNumber, name, age, grade, position);
                        break;

                    case 4:
                        Console.Write("Enter Roll Number to Delete: ");
                        rollNumber = Convert.ToInt32(Console.ReadLine());
                        studentList.DeleteByRollNumber(rollNumber);
                        break;

                    case 5:
                        Console.Write("Enter Roll Number to Search: ");
                        rollNumber = Convert.ToInt32(Console.ReadLine());
                        studentList.SearchByRollNumber(rollNumber);
                        break;

                    case 6:
                        studentList.DisplayAll();
                        break;

                    case 7:
                        Console.Write("Enter Roll Number to Update Grade: ");
                        rollNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter New Grade: ");
                        grade = Convert.ToChar(Console.ReadLine());
                        studentList.UpdateGrade(rollNumber, grade);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice! Try Again.");
                        break;
                }
            }
        }
    }
}
