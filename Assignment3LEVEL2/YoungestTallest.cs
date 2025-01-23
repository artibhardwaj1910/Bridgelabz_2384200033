using System;
class YoungestTallest{
    static void Main(){
        // Input for Amar
        Console.Write("Enter Amar's age: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Amar's height in cm: ");
        int amarHeight = Convert.ToInt32(Console.ReadLine());

        // Input for Akbar
        Console.Write("Enter Akbar's age: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Akbar's height in cm: ");
        int akbarHeight = Convert.ToInt32(Console.ReadLine());

        // Input for Anthony
        Console.Write("Enter Anthony's age: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Anthony's height in cm: ");
        int anthonyHeight = Convert.ToInt32(Console.ReadLine());

        // Determine the youngest friend by comparing ages
        string youngestFriend;
        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));

        if (youngestAge == amarAge)
            youngestFriend = "Amar";
        else if (youngestAge == akbarAge)
            youngestFriend = "Akbar";
        else
            youngestFriend = "Anthony";

        // Determine the tallest friend by comparing heights
        string tallestFriend;
        int tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));

        if (tallestHeight == amarHeight)
            tallestFriend = "Amar";
        else if (tallestHeight == akbarHeight)
            tallestFriend = "Akbar";
        else
            tallestFriend = "Anthony";

        // Display the results
        Console.WriteLine($"\nThe youngest friend is {youngestFriend} with an age of {youngestAge} years.");
        Console.WriteLine($"The tallest friend is {tallestFriend} with a height of {tallestHeight} cm."); }}