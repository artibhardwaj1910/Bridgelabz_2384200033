using System;
namespace KeywordAssignment
{
    class BankAccount
    {
        private static string bankName = "Global Bank"; 
        private static int totalAccounts = 0; 
        private readonly int accountNumber; 
        private string accountHolderName;
        private double balance;

        public BankAccount(string accountHolderName, int accountNumber, double balance)
        {
            this.accountHolderName = accountHolderName; 
            this.accountNumber = accountNumber;
            this.balance = balance;
            totalAccounts++; 
        }

        public static int GetTotalAccounts()
        {
            return totalAccounts;
        }

        public void DisplayAccountDetails()
        {
            if (this is BankAccount) 
            {
                Console.WriteLine($"Bank: {bankName}");
                Console.WriteLine($"Account Holder: {accountHolderName}");
                Console.WriteLine($"Account Number: {accountNumber}");
                Console.WriteLine($"Balance: {balance}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount account1 = new BankAccount("Alice Johnson", 1001, 5000.50);
            account1.DisplayAccountDetails();
            Console.WriteLine($"Total Accounts: {BankAccount.GetTotalAccounts()}");
        }
    }
}

