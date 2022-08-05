using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryCatch02.Entities;
using TryCatch02.Entities.Exception;
using System.Globalization;

namespace TryCatch02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit: ");
                double limit = double.Parse(Console.ReadLine());

                Account acc = new Account(number, holder, balance, limit);
                Console.Write(Environment.NewLine);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                acc.Withdraw(amount);
                Console.WriteLine($"New Balance: {acc.Balance:C}");
            }
            catch (AccountException e)
            {
                Console.WriteLine($"Error! {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error! {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error! {e.Message}");
            }
        }
    }
}
