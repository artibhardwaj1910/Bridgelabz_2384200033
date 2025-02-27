using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
namespace JSONAssignment{
class Filter
{
    static void Main()
    {
        string json = File.ReadAllText("data.json"); // Assume JSON is an array of objects
        JArray jsonArray = JArray.Parse(json);

        var filteredRecords = jsonArray.Where(obj => (int)obj["age"] > 25);

        Console.WriteLine(JsonConvert.SerializeObject(filteredRecords, Formatting.Indented));
    }
}}

