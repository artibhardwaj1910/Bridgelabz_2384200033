using System;
using System.Collections.Generic;

// Abstract class Product
public abstract class Product
{
    private int productId;
    private string name;
    private double price;

    // Properties for encapsulation
    public int ProductId { get { return productId; } set { productId = value; } }
    public string Name { get { return name; } set { name = value; } }
    public double Price { get { return price; } set { price = value; } }

    public Product(int productId, string name, double price)
    {
        this.ProductId = productId;
        this.Name = name;
        this.Price = price;
    }

    public abstract double CalculateDiscount();
}

// Interface for Taxable Products
public interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Electronics class
public class Electronics : Product, ITaxable
{
    private double discountRate = 0.1; // 10% discount
    private double taxRate = 0.15; // 15% tax

    public Electronics(int productId, string name, double price)
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * discountRate;
    }

    public double CalculateTax()
    {
        return Price * taxRate;
    }

    public string GetTaxDetails()
    {
        return $"Tax Rate: {taxRate * 100}%";
    }
}

// Clothing class
public class Clothing : Product, ITaxable
{
    private double discountRate = 0.2; // 20% discount
    private double taxRate = 0.08; // 8% tax

    public Clothing(int productId, string name, double price)
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * discountRate;
    }

    public double CalculateTax()
    {
        return Price * taxRate;
    }

    public string GetTaxDetails()
    {
        return $"Tax Rate: {taxRate * 100}%";
    }
}

// Groceries class (non-taxable)
public class Groceries : Product
{
    private double discountRate = 0.05; // 5% discount

    public Groceries(int productId, string name, double price)
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * discountRate;
    }
}

// Main Program
class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Electronics(1, "Laptop", 1200),
            new Clothing(2, "T-Shirt", 50),
            new Groceries(3, "Apple", 2)
        };

        foreach (Product product in products)
        {
            double discount = product.CalculateDiscount();
            double tax = product is ITaxable taxableProduct ? taxableProduct.CalculateTax() : 0;
            double finalPrice = product.Price + tax - discount;

            Console.WriteLine($"Product: {product.Name}, Original Price: {product.Price:C}");
            Console.WriteLine($"Discount: -{discount:C}, Tax: +{tax:C}");
            Console.WriteLine($"Final Price: {finalPrice:C}");
            
            if (product is ITaxable taxable)
            {
                Console.WriteLine(taxable.GetTaxDetails());
            }

            Console.WriteLine();
        }
    }
}

