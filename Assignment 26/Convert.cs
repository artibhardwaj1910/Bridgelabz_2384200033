class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class Convert
{
    static void Main()
    {
        Car car = new Car { Make = "Toyota", Model = "Corolla", Year = 2022 };
        string json = JsonConvert.SerializeObject(car, Formatting.Indented);
        Console.WriteLine(json);
    }
}

