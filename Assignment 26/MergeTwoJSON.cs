using System;
using System.IO;
using Newtonsoft.Json.Linq;
namespace JSONAssignment{
class MergeTwoJSON
{
    static void Main()
    {
        string json1 = File.ReadAllText("file1.json");
        string json2 = File.ReadAllText("file2.json");

        JObject obj1 = JObject.Parse(json1);
        JObject obj2 = JObject.Parse(json2);

        obj1.Merge(obj2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });

        Console.WriteLine(obj1.ToString());
    }
}
}

