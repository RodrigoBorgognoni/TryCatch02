using System;
using TryCatch02.Entities.Exception;

namespace TryCatch02.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (number == 0 || holder is null || balance < 0 || withdrawLimit < 0)
            {
                throw new ArgumentException("Invalid information input");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance == 0)
            {
                throw new AccountException("Your balance is zero. Unable to complete Withdraw");
            }
            if (amount > WithdrawLimit)
            {
                throw new AccountException("Insuficient withdraw limit");
            }
            if (amount > Balance)
            {
                throw new AccountException("Insuficient Balance");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account information:{Environment.NewLine}Owner: {Holder}{Environment.NewLine}" +
                   $"Balance: {Balance}";
        }
    }
}
