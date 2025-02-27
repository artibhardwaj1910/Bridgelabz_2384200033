using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using System;
namespace JSONAssignment{
class Validate
{
    static void Main()
    {
        string json = @"{ 'name': 'Alice', 'age': 25 }";
        string schemaJson = @"{
            'type': 'object',
            'properties': {
                'name': { 'type': 'string' },
                'age': { 'type': 'integer' }
            },
            'required': ['name', 'age']
        }";

        JSchema schema = JSchema.Parse(schemaJson);
        JObject obj = JObject.Parse(json);

        bool isValid = obj.IsValid(schema, out IList<string> errors);

        Console.WriteLine(isValid ? "Valid JSON" : "Invalid JSON");
        if (!isValid)
        {
            Console.WriteLine("Errors: " + string.Join(", ", errors));
}}}}
