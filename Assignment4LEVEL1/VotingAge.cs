using System;
class VotingAge{
    static void Main(){
        int[] studentAges = new int[10];

        // For user input
        for (int i = 0; i < studentAges.Length; i++){
            Console.Write($"Enter the age of student {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int age)){
                studentAges[i] = age;}
            else{
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                i--; // Decrement to retry the current index
            }}

        // Check voting eligibility
        foreach (int age in studentAges){
            if (age < 0){
                Console.WriteLine($"Age {age} is invalid.");}
            else if (age >= 18){
                Console.WriteLine($"The student with the age {age} can vote.");}
            else{
                Console.WriteLine($"The student with the age {age} cannot vote."); }}}