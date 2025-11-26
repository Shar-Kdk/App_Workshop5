using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Workshop5
{
    internal class BankAccount
    {
        private string accountNumber;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value > 0)
                    balance = value;
            }
        }

        public BankAccount(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"Invalid deposit amount: {amount}");
                return;
            }

            balance += amount;
            Console.WriteLine($"Deposited: {amount}. New balance: {balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"Invalid withdrawal amount: {amount}");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine($"Withdrawal failed. Tried to withdraw: {amount}, Available: {balance}");
                return;
            }

            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}. Remaining balance: {balance}");
        }
    }
}
