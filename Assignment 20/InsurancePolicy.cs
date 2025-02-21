using System;
using System.Collections.Generic;
namespaceCollectionsAssignment
{
    class InsurancePolicy
    {
        public string PolicyNumber { get; }
        public string HolderName { get; }
        public DateTime ExpiryDate { get; }

        // Constructor to initialize policy details
        public InsurancePolicy(string policyNumber, string holderName, DateTime expiryDate)
        {
            PolicyNumber = policyNumber;
            HolderName = holderName;
            ExpiryDate = expiryDate;
        }

        // Override Equals and GetHashCode for HashSet uniqueness
        public override bool Equals(object obj)
        {
            if (obj is InsurancePolicy policy)
            {
                return PolicyNumber == policy.PolicyNumber;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return PolicyNumber.GetHashCode();
        }

        // Display Policy Info
        public override string ToString()
        {
            return $"PolicyNumber: {PolicyNumber}, Holder: {HolderName}, Expiry: {ExpiryDate:yyyy-MM-dd}";
        }
    }

    class InsurancePolicySystem
    {
        private HashSet<InsurancePolicy> uniquePolicies = new HashSet<InsurancePolicy>();
        private LinkedList<InsurancePolicy> orderedPolicies = new LinkedList<InsurancePolicy>();
        private SortedSet<InsurancePolicy> sortedPolicies = new SortedSet<InsurancePolicy>(new ExpiryDateComparer());

        // Add a new policy
        public void AddPolicy(InsurancePolicy policy)
        {
            if (uniquePolicies.Add(policy))
            {
                orderedPolicies.AddLast(policy);
                sortedPolicies.Add(policy);
                Console.WriteLine("Policy added successfully.");
            }
            else
            {
                Console.WriteLine("Policy already exists.");
            }
        }

        // Display all policies (Insertion Order)
        public void DisplayOrderedPolicies()
        {
            Console.WriteLine("\nPolicies (Insertion Order):");
            foreach (var policy in orderedPolicies)
            {
                Console.WriteLine(policy);
            }
        }

        // Display all policies (Sorted by Expiry Date)
        public void DisplaySortedPolicies()
        {
            Console.WriteLine("\nPolicies (Sorted by Expiry Date):");
            foreach (var policy in sortedPolicies)
            {
                Console.WriteLine(policy);
            }
        }
    }

    // Custom comparer to sort policies by Expiry Date
    class ExpiryDateComparer : IComparer<InsurancePolicy>
    {
        public int Compare(InsurancePolicy x, InsurancePolicy y)
        {
            return x.ExpiryDate.CompareTo(y.ExpiryDate);
        }
    }

    class Program
    {
        static void Main()
        {
            InsurancePolicySystem policySystem = new InsurancePolicySystem();

            // Adding sample policies
            policySystem.AddPolicy(new InsurancePolicy("P001", "Alice", new DateTime(2025, 5, 10)));
            policySystem.AddPolicy(new InsurancePolicy("P002", "Bob", new DateTime(2024, 8, 15)));
            policySystem.AddPolicy(new InsurancePolicy("P003", "Charlie", new DateTime(2026, 1, 5)));
            policySystem.AddPolicy(new InsurancePolicy("P001", "Alice", new DateTime(2025, 5, 10))); // Duplicate

            // Display policies in different orders
            policySystem.DisplayOrderedPolicies();
            policySystem.DisplaySortedPolicies();
        }
    }
}

