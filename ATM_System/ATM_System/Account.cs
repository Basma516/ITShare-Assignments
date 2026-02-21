using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_System
{
    public abstract class Account
    {
        public string AccountNumber { get; }
        public double Balance { get; protected set; }

        protected List<Transaction> Transactions { get; }

        public Account(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            Transactions = new List<Transaction>();
        }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
            Transactions.Add(new Transaction(TransactionType.Deposit, amount));
        }

        public abstract void Withdraw(double amount);

        public void ShowTransactions( List<Transaction> T)
        {
            if (T.Count < 0)
            {
                Console.WriteLine("There isn't Transaction found!");
            }
            else
            {
                foreach (var t in Transactions)
                {
                    Console.WriteLine(t);
                }
            }
        }
    }
}
