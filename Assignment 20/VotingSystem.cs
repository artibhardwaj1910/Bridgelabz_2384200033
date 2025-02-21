
using System;
using System.Collections.Generic;
using System.Linq;
namespace CollectionsAssignment
{
    class VotingSystem
    {
        private Dictionary<string, int> voteCounts = new Dictionary<string, int>(); // Stores votes per candidate
        private SortedDictionary<string, int> sortedResults = new SortedDictionary<string, int>(); // Sorted results
        private LinkedList<string> voteOrder = new LinkedList<string>(); // Maintains vote order

        // Cast a vote
        public void CastVote(string candidate)
        {
            // Update vote count
            if (!voteCounts.ContainsKey(candidate))
            {
                voteCounts[candidate] = 0;
            }
            voteCounts[candidate]++;

            // Maintain vote order
            voteOrder.AddLast(candidate);

            Console.WriteLine($"Vote cast for {candidate}.");
        }

        // Display total vote count
        public void DisplayVoteCounts()
        {
            Console.WriteLine("\nTotal Votes:");
            foreach (var kvp in voteCounts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} votes");
            }
        }

        // Display results in alphabetical order
        public void DisplaySortedResults()
        {
            sortedResults = new SortedDictionary<string, int>(voteCounts);

            Console.WriteLine("\nResults in Alphabetical Order:");
            foreach (var kvp in sortedResults)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} votes");
            }
        }

        // Display votes in the order they were cast
        public void DisplayVoteOrder()
        {
            Console.WriteLine("\nVotes in Order Cast:");
            foreach (var candidate in voteOrder)
            {
                Console.Write(candidate + " → ");
            }
            Console.WriteLine("End");
        }
    }

    class Program
    {
        static void Main()
        {
            VotingSystem votingSystem = new VotingSystem();

            // Casting votes
            votingSystem.CastVote("Alice");
            votingSystem.CastVote("Bob");
            votingSystem.CastVote("Alice");
            votingSystem.CastVote("Charlie");
            votingSystem.CastVote("Bob");
            votingSystem.CastVote("Alice");

            // Display results
            votingSystem.DisplayVoteCounts();
            votingSystem.DisplaySortedResults();
            votingSystem.DisplayVoteOrder();
        }
    }
}

