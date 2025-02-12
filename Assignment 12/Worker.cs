using System;

namespace InheritenceAssignment
{
    // Superclass Person
    class Person
    {
        protected string name;
        protected int id;

        // Constructor to initialize Person attributes
        public Person(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        // Method to display personal details
        public void DisplayPersonDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
        }
    }

    // Interface Worker
    interface Worker
    {
        void PerformDuties(); // Method to be implemented by subclasses
    }

    // Subclass Chef inheriting from Person and implementing Worker interface
    class Chef : Person, Worker
    {
        private string specialty;

        // Constructor to initialize Chef attributes
        public Chef(string name, int id, string specialty)
            : base(name, id)
        {
            this.specialty = specialty;
        }

        // Implementing PerformDuties() method
        public void PerformDuties()
        {
            Console.WriteLine("Role: Chef");
            DisplayPersonDetails();
            Console.WriteLine("Specialty: " + specialty);
            Console.WriteLine("Duties: Cooking delicious meals.");
        }
    }

    // Subclass Waiter inheriting from Person and implementing Worker interface
    class Waiter : Person, Worker
    {
        private string assignedSection;

        // Constructor to initialize Waiter attributes
        public Waiter(string name, int id, string assignedSection)
            : base(name, id)
        {
            this.assignedSection = assignedSection;
        }

        // Implementing PerformDuties() method
        public void PerformDuties()
        {
            Console.WriteLine("Role: Waiter");
            DisplayPersonDetails();
            Console.WriteLine("Assigned Section: " + assignedSection);
            Console.WriteLine("Duties: Serving food and attending customers.");
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            // Creating objects of Chef and Waiter
            Chef chef = new Chef("Vikram Singh", 101, "Indian Cuisine");
            Waiter waiter = new Waiter("Ramesh Kumar", 202, "Outdoor Seating");

            // Displaying roles and duties
            chef.PerformDuties();
            Console.WriteLine();
            waiter.PerformDuties();
        }
    }
}
