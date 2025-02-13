using System;
namespace BankingSystem
{
    // Abstract class BankAccount
    public abstract class BankAccount
    {
        // Encapsulated fields
        private string accountNumber;
        private string holderName;
        protected double balance;

        // Constructor
        public BankAccount(string accountNumber, string holderName, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = initialBalance;
        }

        // Properties
        public string AccountNumber => accountNumber;
        public string HolderName => holderName;
        public double Balance => balance;

        // Methods
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount}. New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        // Abstract method for interest calculation
        public abstract void CalculateInterest();
    }

    // SavingsAccount subclass
    public class SavingsAccount : BankAccount
    {
        private double interestRate = 0.05; // 5% interest

        public SavingsAccount(string accountNumber, string holderName, double initialBalance)
            : base(accountNumber, holderName, initialBalance) { }

        public override void CalculateInterest()
        {
            double interest = balance * interestRate;
            balance += interest;
            Console.WriteLine($"Savings Account Interest Applied: {interest}. New Balance: {balance}");
        }
    }

    // CurrentAccount subclass
    public class CurrentAccount : BankAccount
    {
        private double overdraftLimit = 5000;

        public CurrentAccount(string accountNumber, string holderName, double initialBalance)
            : base(accountNumber, holderName, initialBalance) { }

        public override void CalculateInterest()
        {
            Console.WriteLine("Current accounts do not earn interest.");
        }

        public override void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance + overdraftLimit)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount} from Current Account. New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Withdrawal exceeds overdraft limit.");
            }
        }
    }

    // Interface for Loan functionality
    public interface ILoanable
    {
        void ApplyForLoan(double amount);
        bool CalculateLoanEligibility();
    }

    // LoanAccount implementing ILoanable
    public class LoanAccount : ILoanable
    {
        private string holderName;
        private double loanAmount;
        private double annualIncome;

        public LoanAccount(string holderName, double annualIncome)
        {
            this.holderName = holderName;
            this.annualIncome = annualIncome;
        }

        public void ApplyForLoan(double amount)
        {
            if (CalculateLoanEligibility())
            {
                loanAmount = amount;
                Console.WriteLine($"{holderName} approved for a loan of {amount}");
            }
            else
            {
                Console.WriteLine($"{holderName} is not eligible for a loan.");
            }
        }

        public bool CalculateLoanEligibility()
        {
            return annualIncome >= 25000; // Example condition
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount savings = new SavingsAccount("SAV123", "Alice", 1000);
            savings.Deposit(500);
            savings.CalculateInterest();

            BankAccount current = new CurrentAccount("CUR456", "Bob", 2000);
            current.Withdraw(3000);
            current.CalculateInterest();

            ILoanable loanAccount = new LoanAccount("Charlie", 30000);
            loanAccount.ApplyForLoan(10000);
        }
    }
}

