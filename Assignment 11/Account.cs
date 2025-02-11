using System;
using System.Collections.Generic;
namespace ObjectModelAssignment{

	class Account{
		
		private double accountNumber;
		private double balance;
		
		public Account(double accountnumber, double balance){
		this.accountNumber = accountNumber;
		this.balance = balance;
		}
		
		public double GetAccountNumer(){
			return accountNumber;
		}
		
		public double Getbalance(){
			return balance;
		}
		
		public void deposit (double amount){
			
			if (amount > 0){
			balance += amount;
			Console.WriteLine($"Deposited {amount} into account {accountNumber}. New balance: {balance}");
			}else{
                Console.WriteLine("Invalid deposit amount.");
            }
		}
			
		public void withdraw(double amount){
			
			if(amount > 0 && amount <= balance){
			balance -= amount;
			Console.WriteLine($"Withdrawn {amount} from account {accountNumber}. New balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
		}
	}
	
	class Customer{
	
		private string name;
		private List<Account> accounts;
		
		public customer(string name){
		this.name = name;
		this.accounts = new List<Account>();
		}
		
		public string GetName(){
		return name;
		}
		
		public void AddAccount(Account account){
			accounts.Add(account);
		}
		
		 public void ViewBalance()
        {
            Console.WriteLine($"{name}'s Accounts:");
            foreach (Account account in accounts)
            {
                Console.WriteLine($"Account Number: {account.GetAccountNumber()}, Balance: {account.GetBalance()}");
            }
            Console.WriteLine();
        }
    }
	
	class Bank
    {
        private string bankName;
        private List<Customer> customers; // Association: Bank has multiple customers

        public Bank(string bankName)
        {
            this.bankName = bankName;
            this.customers = new List<Customer>();
        }

        public string GetBankName()
        {
            return bankName;
        }

        public Account OpenAccount(Customer customer, int accountNumber, double initialBalance)
        {
            Account newAccount = new Account(accountNumber, initialBalance);
            customer.AddAccount(newAccount);
            if (!customers.Contains(customer))
            {
                customers.Add(customer);
            }
            Console.WriteLine($"Account {accountNumber} opened for {customer.GetName()} at {bankName}.");
            return newAccount;
        }
    }

    class Program
    {
        static void Main()
        {
            Bank bank1 = new Bank("National Bank");

            Customer customer1 = new Customer("Alice");
            Customer customer2 = new Customer("Bob");

            Account account1 = bank1.OpenAccount(customer1, 1001, 5000);
            Account account2 = bank1.OpenAccount(customer1, 1002, 3000);
            Account account3 = bank1.OpenAccount(customer2, 2001, 7000);

            customer1.ViewBalance();
            customer2.ViewBalance();

            account1.Deposit(2000);
            account2.Withdraw(500);
            account3.Withdraw(8000);

            customer1.ViewBalance();
            customer2.ViewBalance();
        }
    }	
}
