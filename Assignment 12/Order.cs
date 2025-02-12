using System;

namespace InheritenceAssignment
{
    // Base class Order
    class Order
    {
        protected int orderId;
        protected string orderDate;

        // Constructor to initialize Order attributes
        public Order(int orderId, string orderDate)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
        }

        // Method to get order status
        public virtual void GetOrderStatus()
        {
            Console.WriteLine("Order ID: " + orderId);
            Console.WriteLine("Order Date: " + orderDate);
            Console.WriteLine("Status: Order placed.");
        }
    }

    // Subclass ShippedOrder inheriting from Order
    class ShippedOrder : Order
    {
        protected string trackingNumber;

        // Constructor to initialize ShippedOrder attributes
        public ShippedOrder(int orderId, string orderDate, string trackingNumber) : base(orderId, orderDate)
        {
            this.trackingNumber = trackingNumber;
        }

        // Overriding GetOrderStatus to include shipping details
        public override void GetOrderStatus()
        {
            Console.WriteLine("Order ID: " + orderId);
            Console.WriteLine("Order Date: " + orderDate);
            Console.WriteLine("Tracking Number: " + trackingNumber);
            Console.WriteLine("Status: Order shipped.");
        }
    }

    // Subclass DeliveredOrder inheriting from ShippedOrder
    class DeliveredOrder : ShippedOrder
    {
        private string deliveryDate;

        // Constructor to initialize DeliveredOrder attributes
        public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate) 
            : base(orderId, orderDate, trackingNumber)
        {
            this.deliveryDate = deliveryDate;
        }

        // Overriding GetOrderStatus to include delivery details
        public override void GetOrderStatus()
        {
            Console.WriteLine("Order ID: " + orderId);
            Console.WriteLine("Order Date: " + orderDate);
            Console.WriteLine("Tracking Number: " + trackingNumber);
            Console.WriteLine("Delivery Date: " + deliveryDate);
            Console.WriteLine("Status: Order delivered.");
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            // Creating an object of DeliveredOrder
            DeliveredOrder order = new DeliveredOrder(12345, "05-Feb-2025", "TRK987654321", "08-Feb-2025");

            // Displaying order status
            order.GetOrderStatus();
        }
    }
}
