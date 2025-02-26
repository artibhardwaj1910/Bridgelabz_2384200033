using System;
namespace Annotation{
public class LegacyAPI
{
        // Marking the OldFeature method as obsolete with a warning message
        [Obsolete("OldFeature is deprecated. Use NewFeature instead.")]
        public void OldFeature()
        {
            Console.WriteLine("This is the old feature.");
        }

        // New feature that should be used instead
        public void NewFeature()
        {
            Console.WriteLine("This is the new feature.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Instantiate LegacyAPI object
            LegacyAPI legacyApi = new LegacyAPI();

            // Call the obsolete method (this will generate a warning)
            legacyApi.OldFeature();

            // Call the new method
            legacyApi.NewFeature();
        }
    }}
}
