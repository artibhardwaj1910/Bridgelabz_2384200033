using System.Collections.Generic;
using Newtonsoft.Json;
namespace JSONAssignment{
class ConvertList
{
    static void Main()
    {
        List<Car> cars = new List<Car>
        {
            new Car { Make = "Toyota", Model = "Camry", Year = 2022 },
            new Car { Make = "Honda", Model = "Civic", Year = 2021 }
        };

        string json = JsonConvert.SerializeObject(cars, Formatting.Indented);
        Console.WriteLine(json);
    }
}}

