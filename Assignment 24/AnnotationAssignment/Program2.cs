using System;
using System.Collections;
namespace Annotation{
public class Program2
{
        public static void Main(string[] args)
        {
            // Suppress the warnings related to unchecked operations for non-generic ArrayList
            #pragma warning disable 8600, 8604

            // Create an ArrayList without generics
            ArrayList list = new ArrayList();

            // Add elements to the ArrayList
            list.Add(10);
            list.Add("Hello");
            list.Add(3.14);

            // Iterate over the elements in the ArrayList
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Re-enable the warnings (optional)
            #pragma warning restore 8600, 8604
        }
    }
}}
