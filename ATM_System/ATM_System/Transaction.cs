using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_System
{
    public class Transaction
    {
        public DateTime Date { get; }
        public TransactionType Type { get; }
        public double Amount { get; }

        public Transaction(TransactionType type, double amount)
        {
            Date = DateTime.Now;
            Type = type;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{Date} - {Type} - {Amount:C}";
        }
    }
}