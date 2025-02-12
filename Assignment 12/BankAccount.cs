using System;

namespace InheritenceAssignment
{
    // Base class BankAccount
    class BankAccount
    {
        protected int accountNumber;
        protected double balance;

        // Constructor to initialize BankAccount attributes
        public BankAccount(int accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        // Method to display account details
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Balance: ₹" + balance);
        }
    }

    // Subclass SavingsAccount inheriting from BankAccount
    class SavingsAccount : BankAccount
    {
        private double interestRate;

        // Constructor to initialize SavingsAccount attributes
        public SavingsAccount(int accountNumber, double balance, double interestRate) 
            : base(accountNumber, balance)
        {
            this.interestRate = interestRate;
        }

        // Method to display account type
        public void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Savings Account");
            DisplayAccountDetails();
            Console.WriteLine("Interest Rate: " + interestRate + "%");
        }
    }

    // Subclass CheckingAccount inheriting from BankAccount
    class CheckingAccount : BankAccount
    {
        private double withdrawalLimit;

        // Constructor to initialize CheckingAccount attributes
        public CheckingAccount(int accountNumber, double balance, double withdrawalLimit) 
            : base(accountNumber, balance)
        {
            this.withdrawalLimit = withdrawalLimit;
        }

        // Method to display account type
        public void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Checking Account");
            DisplayAccountDetails();
            Console.WriteLine("Withdrawal Limit: ₹" + withdrawalLimit);
        }
    }

    // Subclass FixedDepositAccount inheriting from BankAccount
    class FixedDepositAccount : BankAccount
    {
        private int maturityPeriod; // in months

        // Constructor to initialize FixedDepositAccount attributes
        public FixedDepositAccount(int accountNumber, double balance, int maturityPeriod) 
            : base(accountNumber, balance)
        {
            this.maturityPeriod = maturityPeriod;
        }

        // Method to display account type
        public void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Fixed Deposit Account");
            DisplayAccountDetails();
            Console.WriteLine("Maturity Period: " + maturityPeriod + " months");
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            // Creating objects of different account types
            SavingsAccount savings = new SavingsAccount(1001, 50000, 4.5);
            CheckingAccount checking = new CheckingAccount(1002, 30000, 10000);
            FixedDepositAccount fixedDeposit = new FixedDepositAccount(1003, 100000, 12);

            // Displaying account details
            savings.DisplayAccountType();
            Console.WriteLine();
            checking.DisplayAccountType();
            Console.WriteLine();
            fixedDeposit.DisplayAccountType();
        }
    }
}
