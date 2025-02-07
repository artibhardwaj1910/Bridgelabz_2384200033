using System;
namespace DateNTimeAssignment
{
    class TimeZones
    {
        static void Main()
        {
            // Get the current UTC time
            DateTimeOffset currentUtcTime = DateTimeOffset.UtcNow;

            // Define time zones
            TimeZoneInfo gmtTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            TimeZoneInfo istTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            TimeZoneInfo pstTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

            // Convert the current UTC time to the respective time zones
            DateTime gmtTime = TimeZoneInfo.ConvertTime(currentUtcTime, gmtTimeZone).DateTime;
            DateTime istTime = TimeZoneInfo.ConvertTime(currentUtcTime, istTimeZone).DateTime;
            DateTime pstTime = TimeZoneInfo.ConvertTime(currentUtcTime, pstTimeZone).DateTime;

            // Display the results
            Console.WriteLine("Current Time in Different Time Zones:");
            Console.WriteLine("GMT (Greenwich Mean Time): " + gmtTime);
            Console.WriteLine("IST (Indian Standard Time): " + istTime);
            Console.WriteLine("PST (Pacific Standard Time): " + pstTime);
        }
    }
}

