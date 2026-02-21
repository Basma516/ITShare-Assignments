namespace ATM_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account;
            UserCredentials credentials= new UserCredentials("4242 4242 4242 4242", 1234);
            Console.WriteLine("Select Account Type:");
            Console.WriteLine("1. Current Account");
            Console.WriteLine("2. Savings Account");
            Console.Write("select an option: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            if (choice == 1)
            {
                account = new CurrentAccount("CUR-123", 3000);
            }
            else
            {
                account = new SavingsAccount("SAV-456", 5000);
            }

            ATMMachine atm = new ATMMachine(account , credentials);
            atm.Run();
        }
    
    }
}
