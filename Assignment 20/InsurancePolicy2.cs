using System;
using System.Collections.Generic;
using System.Linq;
namespace CollectionsAssignment
{
    class InsurancePolicy
    {
        public string PolicyNumber { get; }
        public string HolderName { get; }
        public DateTime ExpiryDate { get; }
        public string CoverageType { get; }  // New field for coverage type

        // Constructor
        public InsurancePolicy(string policyNumber, string holderName, DateTime expiryDate, string coverageType)
        {
            PolicyNumber = policyNumber;
            HolderName = holderName;
            ExpiryDate = expiryDate;
            CoverageType = coverageType;
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
            return $"PolicyNumber: {PolicyNumber}, Holder: {HolderName}, Expiry: {ExpiryDate:yyyy-MM-dd}, Coverage: {CoverageType}";
        }
    }

    class InsurancePolicySystem
    {
        private HashSet<InsurancePolicy> uniquePolicies = new HashSet<InsurancePolicy>();
        private LinkedList<InsurancePolicy> orderedPolicies = new LinkedList<InsurancePolicy>();
        private SortedSet<InsurancePolicy> sortedPolicies = new SortedSet<InsurancePolicy>(new ExpiryDateComparer());
        private Dictionary<string, int> policyCount = new Dictionary<string, int>(); // Track duplicates

        // Add a new policy
        public void AddPolicy(InsurancePolicy policy)
        {
            if (uniquePolicies.Add(policy))
            {
                orderedPolicies.AddLast(policy);
                sortedPolicies.Add(policy);
                if (!policyCount.ContainsKey(policy.PolicyNumber))
                {
                    policyCount[policy.PolicyNumber] = 1;
                }
                Console.WriteLine("Policy added successfully.");
            }
            else
            {
                policyCount[policy.PolicyNumber]++;
                Console.WriteLine("Duplicate policy detected.");
            }
        }

        // Retrieve all unique policies
        public void DisplayAllUniquePolicies()
        {
            Console.WriteLine("\nAll Unique Policies:");
            foreach (var policy in uniquePolicies)
            {
                Console.WriteLine(policy);
            }
        }

        // Retrieve policies expiring within 30 days
        public void DisplayExpiringSoon()
        {
            DateTime today = DateTime.Today;
            DateTime threshold = today.AddDays(30);

            var expiringPolicies = sortedPolicies.Where(p => p.ExpiryDate <= threshold).ToList();

            Console.WriteLine("\nPolicies Expiring Within 30 Days:");
            if (expiringPolicies.Count == 0)
            {
                Console.WriteLine("No policies expiring soon.");
            }
            else
            {
                foreach (var policy in expiringPolicies)
                {
                    Console.WriteLine(policy);
                }
            }
        }

        // Retrieve policies by coverage type
        public void DisplayPoliciesByCoverage(string coverageType)
        {
            var filteredPolicies = uniquePolicies.Where(p => p.CoverageType.Equals(coverageType, StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine($"\nPolicies with Coverage Type: {coverageType}");
            if (filteredPolicies.Count == 0)
            {
                Console.WriteLine("No policies found.");
            }
            else
            {
                foreach (var policy in filteredPolicies)
                {
                    Console.WriteLine(policy);
                }
            }
        }

        // Retrieve duplicate policies
        public void DisplayDuplicatePolicies()
        {
            Console.WriteLine("\nDuplicate Policies:");
            bool found = false;
            foreach (var kvp in policyCount)
            {
                if (kvp.Value > 1)
                {
                    Console.WriteLine($"Policy Number: {kvp.Key}, Duplicates: {kvp.Value}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No duplicate policies found.");
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
            policySystem.AddPolicy(new InsurancePolicy("P001", "Alice", new DateTime(2025, 5, 10), "Health"));
            policySystem.AddPolicy(new InsurancePolicy("P002", "Bob", new DateTime(2024, 3, 15), "Auto"));
            policySystem.AddPolicy(new InsurancePolicy("P003", "Charlie", new DateTime(2024, 8, 5), "Home"));
            policySystem.AddPolicy(new InsurancePolicy("P004", "David", new DateTime(2024, 3, 10), "Health"));
            policySystem.AddPolicy(new InsurancePolicy("P001", "Alice", new DateTime(2025, 5, 10), "Health")); // Duplicate

            // Retrieve policies
            policySystem.DisplayAllUniquePolicies();
            policySystem.DisplayExpiringSoon();
            policySystem.DisplayPoliciesByCoverage("Health");
            policySystem.DisplayDuplicatePolicies();
        }
    }
}

