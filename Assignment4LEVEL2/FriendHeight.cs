using System;
class FriendHeight{
    static void Main(){
        // Arrays to store ages and heights
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Input age and height
        Console.WriteLine("Enter the details for the 3 friends:");

        for (int i = 0; i < 3; i++){
            // Input for age
            Console.Write($"Enter the age of friend {i + 1} (Amar, Akbar, or Anthony): ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            // Input for height
            Console.Write($"Enter the height of friend {i + 1} (in cm): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());}

        // Find the youngest and the tallest friend
        int youngestAge = ages[0];
        double tallestHeight = heights[0];
        string youngestFriend = "Amar";
        string tallestFriend = "Amar";

        for (int i = 1; i < 3; i++){
            // Check for youngest friend
            if (ages[i] < youngestAge){
                youngestAge = ages[i];
                youngestFriend = i == 1 ? "Akbar" : "Anthony";}

            // Check for tallest friend
            if (heights[i] > tallestHeight){
                tallestHeight = heights[i];
                tallestFriend = i == 1 ? "Akbar" : "Anthony";}}

        // Display the result
        Console.WriteLine($"\nThe youngest friend is: {youngestFriend} (Age: {youngestAge})");
        Console.WriteLine($"The tallest friend is: {tallestFriend} (Height: {tallestHeight} cm)");}}