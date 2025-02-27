using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.Collections.Generic;
namespace JSONAssignment{
class ValidateEmail
{
    static void Main()
    {
        string json = @"{ 'name': 'Alice', 'email': 'alice@example.com' }";
        string schemaJson = @"{
            'type': 'object',
            'properties': {
                'email': { 'type': 'string', 'format': 'email' }
            },
            'required': ['email']
        }";

        JSchema schema = JSchema.Parse(schemaJson);
        JObject obj = JObject.Parse(json);

        bool isValid = obj.IsValid(schema, out IList<string> errors);

        Console.WriteLine(isValid ? "Valid Email" : "Invalid Email");
        if (!isValid) Console.WriteLine(string.Join(", ", errors));
}}}

