using System;
using System.Collections.Generic;
namespace CollectionsAssignment
{
    class HospitalTriageSystem
    {
        // Method to process patients based on severity
        static void ProcessPatients(List<(string name, int severity)> patients)
        {
            // PriorityQueue where higher severity gets treated first
            PriorityQueue<string, int> triageQueue = new PriorityQueue<string, int>();

            // Enqueue patients (inverting severity to give higher numbers priority)
            foreach (var patient in patients)
            {
                triageQueue.Enqueue(patient.name, -patient.severity);
            }

            // Process and display treatment order
            Console.WriteLine("Treatment Order:");
            while (triageQueue.Count > 0)
            {
                Console.WriteLine(triageQueue.Dequeue());
            }
        }

        static void Main()
        {
            // Define patient list (name, severity)
            List<(string, int)> patients = new List<(string, int)>
            {
                ("John", 3),
                ("Alice", 5),
                ("Bob", 2)
            };

            // Process and display patient order
            ProcessPatients(patients);
        }
    }
}

