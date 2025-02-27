using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
namespace JSONAssignment{
class ConvertIntoXML
{
    static void Main()
    {
        string json = @"{ 'name': 'John', 'age': 30, 'city': 'New York' }";

        JObject obj = JObject.Parse(json);
        XDocument xml = JsonConvert.DeserializeXNode(obj.ToString(), "Root");

        Console.WriteLine(xml);
    }
}}

