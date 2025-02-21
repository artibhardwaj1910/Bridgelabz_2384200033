
using System;
using System.Collections.Generic;
using System.Linq;
namespace CollectionsAssignment
{
    class BankingSystem
    {
        private Dictionary<int, double> accountBalances = new Dictionary<int, double>(); // Store account balances
        private SortedDictionary<double, List<int>> sortedBalances = new SortedDictionary<double, List<int>>(); // Sort by balance
        private Queue<Tuple<int, double>> withdrawalQueue = new Queue<Tuple<int, double>>(); // Process withdrawals

        // Open a new account
        public void OpenAccount(int accountNumber, double initialDeposit)
        {
            if (!accountBalances.ContainsKey(accountNumber))
            {
                accountBalances[accountNumber] = initialDeposit;
                Console.WriteLine($"Account {accountNumber} opened with balance: ${initialDeposit}");
                
                AddToSortedBalances(accountNumber, initialDeposit);
            }
            else
            {
                Console.WriteLine("Account number already exists!");
            }
        }

        // Deposit money
        public void Deposit(int accountNumber, double amount)
        {
            if (accountBalances.ContainsKey(accountNumber))
            {
                double oldBalance = accountBalances[accountNumber];
                accountBalances[accountNumber] += amount;
                Console.WriteLine($"Deposited ${amount} into account {accountNumber}. New balance: ${accountBalances[accountNumber]}");

                UpdateSortedBalances(accountNumber, oldBalance, accountBalances[accountNumber]);
            }
            else
            {
                Console.WriteLine("Account not found!");
            }
        }

        // Request withdrawal (adds to queue)
        public void RequestWithdrawal(int accountNumber, double amount)
        {
            if (accountBalances.ContainsKey(accountNumber) && accountBalances[accountNumber] >= amount)
            {
                withdrawalQueue.Enqueue(new Tuple<int, double>(accountNumber, amount));
                Console.WriteLine($"Withdrawal request of ${amount} from account {accountNumber} added to queue.");
            }
            else
            {
                Console.WriteLine("Insufficient funds or account not found!");
            }
        }

        // Process withdrawals
        public void ProcessWithdrawals()
        {
            while (withdrawalQueue.Count > 0)
            {
                var transaction = withdrawalQueue.Dequeue();
                int accountNumber = transaction.Item1;
                double amount = transaction.Item2;

                if (accountBalances.ContainsKey(accountNumber) && accountBalances[accountNumber] >= amount)
                {
                    double oldBalance = accountBalances[accountNumber];
                    accountBalances[accountNumber] -= amount;
                    Console.WriteLine($"Processed withdrawal of ${amount} from account {accountNumber}. New balance: ${accountBalances[accountNumber]}");

                    UpdateSortedBalances(accountNumber, oldBalance, accountBalances[accountNumber]);
                }
            }
        }

        // Display all account balances sorted by balance
        public void DisplaySortedAccounts()
        {
            Console.WriteLine("\nAccounts Sorted by Balance:");
            foreach (var balance in sortedBalances.Keys)
            {
                foreach (var account in sortedBalances[balance])
                {
                    Console.WriteLine($"Account {account}: ${balance}");
                }
            }
        }

        // Helper method to add account to sortedBalances
        private void AddToSortedBalances(int accountNumber, double balance)
        {
            if (!sortedBalances.ContainsKey(balance))
            {
                sortedBalances[balance] = new List<int>();
            }
            sortedBalances[balance].Add(accountNumber);
        }

        // Helper method to update sortedBalances when balance changes
        private void UpdateSortedBalances(int accountNumber, double oldBalance, double newBalance)
        {
            if (sortedBalances.ContainsKey(oldBalance))
            {
                sortedBalances[oldBalance].Remove(accountNumber);
                if (sortedBalances[oldBalance].Count == 0)
                {
                    sortedBalances.Remove(oldBalance);
                }
            }

            AddToSortedBalances(accountNumber, newBalance);
        }
    }

    class Program
    {
        static void Main()
        {
            BankingSystem bank = new BankingSystem();

            // Opening accounts
            bank.OpenAccount(101, 5000);
            bank.OpenAccount(102, 3000);
            bank.OpenAccount(103, 7000);

            // Deposits
            bank.Deposit(101, 2000);
            bank.Deposit(102, 1000);

            // Withdrawal requests
            bank.RequestWithdrawal(101, 1500);
            bank.RequestWithdrawal(103, 500);

            // Processing withdrawals
            bank.ProcessWithdrawals();

            // Display sorted balances
            bank.DisplaySortedAccounts();
        }
    }
}

