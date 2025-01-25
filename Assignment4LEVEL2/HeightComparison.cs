using System;
class HeightComparison{
    static void Main(){
        // Initialize variables
        int maxFriendCount = 3;
        string[] friends = { "Amar", "Akbar", "Anthony" };

        // Create dynamic arrays for storing ages and heights of friends
        int[] ages = new int[maxFriendCount];
        double[] heights = new double[maxFriendCount];

        int index = 0;

        // Input ages and heights for each friend
        for (index = 0; index < maxFriendCount; index++){
            Console.Write($"Enter the age of {friends[index]}: ");
            ages[index] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter the height of {friends[index]} (in cm): ");
            heights[index] = Convert.ToDouble(Console.ReadLine());

            // Check if the index has reached limit, then resize arrays
            if (index == maxFriendCount - 1){
                maxFriendCount += 3;
                Array.Resize(ref ages, maxFriendCount);
                Array.Resize(ref heights, maxFriendCount); }}

        // Find the youngest and the tallest friend
        int youngestAge = ages[0];
        double tallestHeight = heights[0];
        string youngestFriend = friends[0];
        string tallestFriend = friends[0];

        for (int i = 1; i < friends.Length; i++){
            if (ages[i] < youngestAge){
                youngestAge = ages[i];
                youngestFriend = friends[i];}}

            if (heights[i] > tallestHeight){
                tallestHeight = heights[i];
                tallestFriend = friends[i];}}

        // Display the youngest and tallest friend
        Console.WriteLine($"\nThe youngest friend is: {youngestFriend} (Age: {youngestAge})");
        Console.WriteLine($"The tallest friend is: {tallestFriend} (Height: {tallestHeight} cm)"); }}