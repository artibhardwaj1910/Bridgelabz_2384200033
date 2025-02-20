using System;
namespace GenericsAssignment{
abstract class ProductCategory
{
    public string CategoryName { get; set; }

    public ProductCategory(string name)
    {
        CategoryName = name;
    }
}

class BookCategory : ProductCategory
{
    public BookCategory() : base("Books") { }
}

class ClothingCategory : ProductCategory
{
    public ClothingCategory() : base("Clothing") { }
}

class Product<T> where T : ProductCategory
{
    public string Name { get; set; }
    public double Price { get; set; }
    public T Category { get; set; }

    public Product(string name, double price, T category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Product: {Name} | Category: {Category.CategoryName} | Price: ${Price:F2}");
    }
}

class Marketplace
{
    public static void ApplyDiscount<T>(T product, double percentage) where T : Product<ProductCategory>
    {
        if (percentage < 0 || percentage > 100)
        {
            Console.WriteLine("Invalid discount percentage!");
            return;
        }

        product.Price -= product.Price * (percentage / 100);
        Console.WriteLine($"Discount applied! New price of {product.Name}: ${product.Price:F2}");
    }
}

class Program
{
    static void Main()
    {
        Product<BookCategory> book = new Product<BookCategory>("C# Programming", 49.99, new BookCategory());
        Product<ClothingCategory> tshirt = new Product<ClothingCategory>("Cotton T-Shirt", 19.99, new ClothingCategory());

        book.DisplayInfo();
        tshirt.DisplayInfo();

        Marketplace.ApplyDiscount(book, 10);
        Marketplace.ApplyDiscount(tshirt, 15);

        book.DisplayInfo();
        tshirt.DisplayInfo();
    }
}

}