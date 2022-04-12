using System;
using ExercicioFExcecoes.Entities;
using ExercicioFExcecoes.Entities.Exceptions;

namespace ExercicioFExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                double wlimit = double.Parse(Console.ReadLine());
            

                Account account = new Account(number,holder,balance,wlimit);
            
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());

                account.WithDraw(withdraw);

                Console.WriteLine(account);
            }
            catch (WithdrawException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
