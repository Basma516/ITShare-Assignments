
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace ATM_System
{
    public enum TransactionType
    {
        Withdraw=1,
        Deposit,
        CheckBalance,
        ShowTransactions,
        Exit
    }
    internal class ATMMachine
    {
        private readonly UserCredentials _userCredentials;
        private readonly Account _account;

        public ATMMachine(Account account, string cardNumber, int pin)
        {
            _account = account;
            _userCredentials = new UserCredentials(cardNumber, pin);
        }
        public ATMMachine(Account account, UserCredentials userCredentials)
        {
            _account = account;
            _userCredentials = userCredentials;
        }

        public bool AuthenticateUser(string cardNumber, int pin)
        {
            return _userCredentials.CardNumber == cardNumber &&
                   _userCredentials.ValidatePin(pin);
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the ATM Machine!");

            Console.Write("Please enter your card number: ");
            string cardNumber = Console.ReadLine();

            Console.Write("Please enter your PIN: ");
            if (!int.TryParse(Console.ReadLine(), out int pin))
            {
                Console.WriteLine("Invalid PIN format.");
                return;
            }

            int attempts = 0;

            while (!AuthenticateUser(cardNumber, pin))
            {
                attempts++;

                if (attempts >= 3)
                {
                    Console.WriteLine("Account Locked. Please contact the bank.");
                    return;
                }

                Console.WriteLine("Invalid card number or PIN. Try again.");

                Console.Write("Please enter your card number: ");
                cardNumber = Console.ReadLine();

                Console.Write("Please enter your PIN: ");
                if (!int.TryParse(Console.ReadLine(), out pin))
                {
                    Console.WriteLine("Invalid PIN format.");
                    continue;
                }
            }

            Console.WriteLine("Login successful!");
            ShowMenu();
        }

        private void ShowMenu()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nSelect a transaction:");
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Show Transactions");
                Console.WriteLine("5. Exit");

                Console.Write("Choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                TransactionType transactionType = (TransactionType)choice;

                switch (transactionType)
                {
                    case TransactionType.Withdraw:
                        Withdraw();
                        break;

                    case TransactionType.Deposit:
                        Deposit();
                        break;

                    case TransactionType.CheckBalance:
                        Console.WriteLine($"Current Balance: {_account.Balance:C}");
                        break;

                    case TransactionType.ShowTransactions:
                        _account.ShowTransactions();
                        break;

                    case TransactionType.Exit:
                        running = false;
                        Console.WriteLine("Thank you for using the ATM!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private void Withdraw()
        {
            Console.Write("Enter amount: ");

            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero.");
                return;
            }

            _account.Withdraw(amount);
        }

        private void Deposit()
        {
            Console.Write("Enter amount: ");

            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero.");
                return;
            }

            _account.Deposit(amount);
        }
    }
}
