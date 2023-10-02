using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class BankAccount
    {
        private string accountNumber;
        private double balance;

      
        public BankAccount(string accNumber)
        {
            accountNumber = accNumber;
            balance = 0.0;
        }

        
        public string GetAccountNumber()
        {
            return accountNumber;
        }

       
        public double GetBalance()
        {
            return balance;
        }

        
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited ${amount} into account {accountNumber}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn ${amount} from account {accountNumber}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
        }
    }
}
