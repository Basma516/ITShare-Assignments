using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_System
{
    public class SavingsAccount : Account
    {
        private double InterestRate = 0.05;

        public SavingsAccount(string accNumber, double balance)
            : base(accNumber, balance)
        {
        }

        public override void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance.");
                return;
            }

            Balance -= amount;
            Transactions.Add(new Transaction(TransactionType.Withdraw, amount));
        }

        public void AddInterest()
        {
            double interest = Balance * InterestRate;
            Balance += interest;
            Transactions.Add(new Transaction(TransactionType.Deposit, interest));
        }
    }
}
