using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class BankAccount
    {
        private int _balance;

        public void Deposit(int amount) 
        {
            if (amount < 0)
            {
                Console.WriteLine("Deposit amount must be positive number!");
            }

            _balance += amount;
            Console.WriteLine($"Successfully deposited {amount}.");
        }
        public int GetBalance()
        {
            return _balance;
        }
    }
}
