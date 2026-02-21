using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Transactions;

namespace ATM_System
{
    public class CurrentAccount : Account
    {
        private double OverdraftLimit = 1000;

        public CurrentAccount(string accNumber, double balance)
            : base(accNumber, balance)
        {
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount < -OverdraftLimit)
            {
                Console.WriteLine("Overdraft limit exceeded.");
                return;
            }

            Balance -= amount;
            Transactions.Add(new Transaction(TransactionType.Withdraw, amount));
        }
    }
}
