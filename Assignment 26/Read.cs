using System.IO;
using Newtonsoft.Json.Linq;
namespace JSONAssignment{
class Read
{
    static void Main()
    {
        string json = File.ReadAllText("data.json"); // Assume it has multiple fields
        JArray jsonArray = JArray.Parse(json);

        foreach (var item in jsonArray)
        {
            Console.WriteLine($"Name: {item["name"]}, Email: {item["email"]}");
        }
    }
}}

