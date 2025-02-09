using System;
namespace AccessModifierAssignment{
    // Base class BankAccount
    class BankAccount{
        // Public, protected, and private members
        public string accountNumber;
        protected string accountHolder;
        private double balance;

        // Constructor to initialize values
        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        // Getter method for balance
        public double GetBalance()
        {
            return balance;
        }

        // Setter method for balance
        public void SetBalance(double balance)
        {
            if (balance >= 0)
            {
                this.balance = balance;
            }
            else
            {
                Console.WriteLine("Invalid balance amount.");
            }
        }
    }

    // Derived class SavingsAccount demonstrating access to accountNumber and accountHolder
    class SavingsAccount : BankAccount
    {
        // Constructor to initialize values, calling base class constructor
        public SavingsAccount(string accountNumber, string accountHolder, double balance)
            : base(accountNumber, accountHolder, balance)
        {
        }

        // Method to display account number and holder's name
        public void DisplayAccountInfo()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder: " + accountHolder);
        }
    }


}
