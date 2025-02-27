using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace JSONAssignment{
class ConvertCSV{
    static void Main()
    {
        string[] lines = File.ReadAllLines("data.csv"); // Assume the first line contains headers
        string[] headers = lines[0].Split(',');
        var jsonArray = new List<Dictionary<string, string>>();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] values = lines[i].Split(',');
            var jsonObject = new Dictionary<string, string>();

            for (int j = 0; j < headers.Length; j++)
            {
                jsonObject[headers[j]] = values[j];
            }
            jsonArray.Add(jsonObject);
        }
        string json = JsonConvert.SerializeObject(jsonArray, Formatting.Indented);
        Console.WriteLine(json);
}}}

