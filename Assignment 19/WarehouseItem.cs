using System;
namespace GenericsAssignment{
abstract class WarehouseItem
{
    public string Name { get; set; }
    
    public WarehouseItem(string name)
    {
        Name = name;
    }

    public abstract void Display();
}

class Electronics : WarehouseItem
{
    public Electronics(string name) : base(name) { }

    public override void Display()
    {
        Console.WriteLine($"Electronics: {Name}");
    }
}

class Groceries : WarehouseItem
{
    public Groceries(string name) : base(name) { }

    public override void Display()
    {
        Console.WriteLine($"Groceries: {Name}");
    }
}

class Furniture : WarehouseItem
{
    public Furniture(string name) : base(name) { }

    public override void Display()
    {
        Console.WriteLine($"Furniture: {Name}");
    }
}

class Storage<T> where T : WarehouseItem
{
    private T[] items;
    private int count = 0;

    public Storage(int capacity)
    {
        items = new T[capacity];
    }

    public void AddItem(T item)
    {
        if (count < items.Length)
        {
            items[count] = item;
            count++;
        }
        else
        {
            Console.WriteLine("Storage is full!");
        }
    }

    public void DisplayItems()
    {
        Console.WriteLine($"Storage contains {count} items:");
        for (int i = 0; i < count; i++)
        {
            items[i].Display();
        }
    }
}

class Program
{
    static void Main()
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>(2);
        electronicsStorage.AddItem(new Electronics("Laptop"));
        electronicsStorage.AddItem(new Electronics("Smartphone"));
        electronicsStorage.DisplayItems();

        Storage<Groceries> groceriesStorage = new Storage<Groceries>(2);
        groceriesStorage.AddItem(new Groceries("Curd"));
        groceriesStorage.AddItem(new Groceries("Milk"));
        groceriesStorage.DisplayItems();

        Storage<Furniture> furnitureStorage = new Storage<Furniture>(2);
        furnitureStorage.AddItem(new Furniture("Table"));
        furnitureStorage.AddItem(new Furniture("Chair"));
        furnitureStorage.DisplayItems();
    }
}

}