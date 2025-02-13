using System;
public abstract class FoodItem
{
    public string ItemName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    // Abstract method to calculate the total price
    public abstract double CalculateTotalPrice();

    // Concrete method to display item details
    public string GetItemDetails()
    {
        return $"{ItemName} - Price: {Price} x Quantity: {Quantity}";
    }
}

public interface IDiscountable
{
    double ApplyDiscount(double discountPercentage);
    string GetDiscountDetails();
}

public class VegItem : FoodItem, IDiscountable
{
    public override double CalculateTotalPrice()
    {
        double totalPrice = Price * Quantity;
        double serviceCharge = totalPrice * 0.05;  // Veg items have an additional service charge of 5%
        return totalPrice + serviceCharge;
    }

    public double ApplyDiscount(double discountPercentage)
    {
        double totalPrice = CalculateTotalPrice();
        return totalPrice - (totalPrice * discountPercentage / 100);
    }

    public string GetDiscountDetails()
    {
        return "Veg items are eligible for a 10% discount!";
    }
}

public class NonVegItem : FoodItem, IDiscountable
{
    public override double CalculateTotalPrice()
    {
        double totalPrice = Price * Quantity;
        double serviceCharge = totalPrice * 0.1;  // Non-Veg items have an additional service charge of 10%
        return totalPrice + serviceCharge;
    }

    public double ApplyDiscount(double discountPercentage)
    {
        double totalPrice = CalculateTotalPrice();
        return totalPrice - (totalPrice * discountPercentage / 100);
    }

    public string GetDiscountDetails()
    {
        return "Non-Veg items are eligible for a 5% discount!";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of VegItem and NonVegItem
        FoodItem vegItem = new VegItem { ItemName = "Veg Pizza", Price = 200, Quantity = 2 };
        FoodItem nonVegItem = new NonVegItem { ItemName = "Chicken Burger", Price = 150, Quantity = 3 };

        // Display item details and total prices before discount
        Console.WriteLine(vegItem.GetItemDetails());
        Console.WriteLine("Total Price (Before Discount): " + vegItem.CalculateTotalPrice());
        Console.WriteLine(nonVegItem.GetItemDetails());
        Console.WriteLine("Total Price (Before Discount): " + nonVegItem.CalculateTotalPrice());

        // Apply discount and display the details
        IDiscountable discountableVegItem = (IDiscountable)vegItem;
        IDiscountable discountableNonVegItem = (IDiscountable)nonVegItem;

        double discountedVegPrice = discountableVegItem.ApplyDiscount(10); // Apply 10% discount
        double discountedNonVegPrice = discountableNonVegItem.ApplyDiscount(5); // Apply 5% discount

        Console.WriteLine("\n" + discountableVegItem.GetDiscountDetails());
        Console.WriteLine("Total Price (After Discount): " + discountedVegPrice);

        Console.WriteLine("\n" + discountableNonVegItem.GetDiscountDetails());
        Console.WriteLine("Total Price (After Discount): " + discountedNonVegPrice);
    }
}

