using Bank.Entities;
using Bank.Entities.Exception;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string name = Console.ReadLine();

            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Withdraw limit: ");
            double withDrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(number, name, balance, withDrawLimit);

            Console.WriteLine(" ");
            Console.WriteLine("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());

            try
            {
                account.WithDraw(amount);
                Console.WriteLine("New balance" + account.Balance.ToString("F2"));
            }
            catch (DomainException e) 
            {
                Console.WriteLine("Withdraw error:" e.Message);
            }
        }
    }
}