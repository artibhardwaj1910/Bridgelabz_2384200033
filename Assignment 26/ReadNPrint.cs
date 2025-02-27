using System;
using System.IO;
using Newtonsoft.Json.Linq;
namespace JSONAssignment{
class ReadNPrint
{
    static void Main()
    {
        string json = File.ReadAllText("data.json");
        JObject jsonObj = JObject.Parse(json);

        foreach (var property in jsonObj.Properties())
        {
            Console.WriteLine($"{property.Name}: {property.Value}");
        }
    }
}}

