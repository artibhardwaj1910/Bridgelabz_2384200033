using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace JSONAssignment{
class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class ConvertIntoArray
{
    static void Main()
    {
        List<Car> cars = new List<Car>
        {
            new Car { Make = "Tesla", Model = "Model 3", Year = 2023 },
            new Car { Make = "Ford", Model = "Mustang", Year = 2022 }
        };

        string json = JsonConvert.SerializeObject(cars, Formatting.Indented);
        Console.WriteLine(json);
    }
}}

