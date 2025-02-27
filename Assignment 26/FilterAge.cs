using System;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Linq;
namespace JSONAssignment{
class FilterAge
{
    static void Main()
    {
        string json = File.ReadAllText("users.json"); // JSON should contain a list of users
        JArray users = JArray.Parse(json);

        var filteredUsers = users.Where(user => (int)user["age"] > 25);

        Console.WriteLine(JsonConvert.SerializeObject(filteredUsers, Formatting.Indented));
    }
}}

