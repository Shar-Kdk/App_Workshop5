namespace App_Workshop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== TASK 1 ========");
            BankAccount acc = new BankAccount("12345", 1000);
            Console.WriteLine("Account: " + acc.AccountNumber);
            acc.Deposit(500);
            acc.Withdraw(300);
            Console.WriteLine("Balance: " + acc.Balance);
            Console.WriteLine();
        }
    }
}
