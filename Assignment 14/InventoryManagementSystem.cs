using System;
namespace InventoryManagementSystem
{
    // Node representing an item in the inventory
    class InventoryNode
    {
        public string ItemName;
        public int ItemID;
        public int Quantity;
        public double Price;
        public InventoryNode Next;

        public InventoryNode(string itemName, int itemID, int quantity, double price)
        {
            ItemName = itemName;
            ItemID = itemID;
            Quantity = quantity;
            Price = price;
            Next = null;
        }
    }

    // Singly Linked List for Inventory Management
    class Inventory
    {
        private InventoryNode head;

        public Inventory()
        {
            head = null;
        }

        // Add an item at the beginning of the list
        public void AddItemAtBeginning(string itemName, int itemID, int quantity, double price)
        {
            InventoryNode newNode = new InventoryNode(itemName, itemID, quantity, price);
            newNode.Next = head;
            head = newNode;
            Console.WriteLine("Item added successfully at the beginning.");
        }

        // Add an item at the end of the list
        public void AddItemAtEnd(string itemName, int itemID, int quantity, double price)
        {
            InventoryNode newNode = new InventoryNode(itemName, itemID, quantity, price);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                InventoryNode temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
            Console.WriteLine("Item added successfully at the end.");
        }

        // Add an item at a specific position
        public void AddItemAtPosition(string itemName, int itemID, int quantity, double price, int position)
        {
            InventoryNode newNode = new InventoryNode(itemName, itemID, quantity, price);
            if (position == 1)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                InventoryNode temp = head;
                for (int i = 1; temp != null && i < position - 1; i++)
                {
                    temp = temp.Next;
                }

                if (temp == null)
                {
                    Console.WriteLine("Invalid position.");
                    return;
                }

                newNode.Next = temp.Next;
                temp.Next = newNode;
            }
            Console.WriteLine("Item added successfully at position " + position);
        }

        // Remove an item by Item ID
        public void RemoveItem(int itemID)
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }

            if (head.ItemID == itemID)
            {
                head = head.Next;
                Console.WriteLine("Item removed successfully.");
                return;
            }

            InventoryNode temp = head;
            while (temp.Next != null && temp.Next.ItemID != itemID)
            {
                temp = temp.Next;
            }

            if (temp.Next == null)
            {
                Console.WriteLine("Item ID not found.");
                return;
            }

            temp.Next = temp.Next.Next;
            Console.WriteLine("Item removed successfully.");
        }

        // Update the quantity of an item by Item ID
        public void UpdateQuantity(int itemID, int newQuantity)
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.ItemID == itemID)
                {
                    temp.Quantity = newQuantity;
                    Console.WriteLine("Quantity updated successfully.");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item ID not found.");
        }

        // Search for an item by Item ID or Item Name
        public void SearchItem(string keyword)
        {
            InventoryNode temp = head;
            bool found = false;
            while (temp != null)
            {
                if (temp.ItemID.ToString() == keyword || temp.ItemName.ToLower() == keyword.ToLower())
                {
                    Console.WriteLine($"Item ID: {temp.ItemID}, Name: {temp.ItemName}, Quantity: {temp.Quantity}, Price: {temp.Price}");
                    found = true;
                }
                temp = temp.Next;
            }
            if (!found)
                Console.WriteLine("Item not found.");
        }

        // Display the total value of inventory
        public void TotalInventoryValue()
        {
            double totalValue = 0;
            InventoryNode temp = head;
            while (temp != null)
            {
                totalValue += temp.Quantity * temp.Price;
                temp = temp.Next;
            }
            Console.WriteLine($"Total Inventory Value: {totalValue}");
        }

        // Display all items in the inventory
        public void DisplayInventory()
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }

            Console.WriteLine("\nCurrent Inventory:");
            InventoryNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"Item ID: {temp.ItemID}, Name: {temp.ItemName}, Quantity: {temp.Quantity}, Price: {temp.Price}");
                temp = temp.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            while (true)
            {
                Console.WriteLine("\nInventory Management System");
                Console.WriteLine("1. Add Item at Beginning");
                Console.WriteLine("2. Add Item at End");
                Console.WriteLine("3. Add Item at Position");
                Console.WriteLine("4. Remove Item");
                Console.WriteLine("5. Update Quantity");
                Console.WriteLine("6. Search Item");
                Console.WriteLine("7. Display Inventory");
                Console.WriteLine("8. Total Inventory Value");
                Console.WriteLine("9. Exit");
                Console.Write("Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 9)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                int itemID, quantity, position;
                string itemName;
                double price;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Item ID: ");
                        itemID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Item Name: ");
                        itemName = Console.ReadLine();
                        Console.Write("Enter Quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Price: ");
                        price = Convert.ToDouble(Console.ReadLine());
                        inventory.AddItemAtBeginning(itemName, itemID, quantity, price);
                        break;

                    case 2:
                        Console.Write("Enter Item ID: ");
                        itemID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Item Name: ");
                        itemName = Console.ReadLine();
                        Console.Write("Enter Quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Price: ");
                        price = Convert.ToDouble(Console.ReadLine());
                        inventory.AddItemAtEnd(itemName, itemID, quantity, price);
                        break;

                    case 3:
                        Console.Write("Enter Item ID: ");
                        itemID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Item Name: ");
                        itemName = Console.ReadLine();
                        Console.Write("Enter Quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Price: ");
                        price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Position: ");
                        position = Convert.ToInt32(Console.ReadLine());
                        inventory.AddItemAtPosition(itemName, itemID, quantity, price, position);
                        break;

                    case 4:
                        Console.Write("Enter Item ID to remove: ");
                        itemID = Convert.ToInt32(Console.ReadLine());
                        inventory.RemoveItem(itemID);
                        break;

                    case 5:
                        Console.Write("Enter Item ID to update quantity: ");
                        itemID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter New Quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        inventory.UpdateQuantity(itemID, quantity);
                        break;

                    case 6:
                        Console.Write("Enter Item ID or Item Name to search: ");
                        string keyword = Console.ReadLine();
                        inventory.SearchItem(keyword);
                        break;

                    case 7:
                        inventory.DisplayInventory();
                        break;

                    case 8:
                        inventory.TotalInventoryValue();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice! Try Again.");
                        break;
                }
            }
        }
    }
}
