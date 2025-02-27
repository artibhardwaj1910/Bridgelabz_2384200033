using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace JSONAssignment{
class CreateJSON
{
    static void Main()
    {
        var student = new
        {
            name = "John Doe",
            age = 20,
            subjects = new string[] { "Math", "Science", "English" }
        };

        string json = JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine(json);
    }
}}

