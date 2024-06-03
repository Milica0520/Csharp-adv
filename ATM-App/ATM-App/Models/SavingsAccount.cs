using ATM_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.Models
{
    public class SavingsAccount : Account,IAccount
    {
        public SavingsAccount(string accountNumber,string pin, double balance):base(accountNumber,pin,balance) 
        {
            AccountNumber = accountNumber;
            Pin = pin;
            Balance = balance;  
        }
        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                Balance = Balance + amount;
                Console.WriteLine($"Deposited {amount}. New balance :{Balance}");
            }
            else
            {
                Console.WriteLine("ou need to enter some amount to deposit.");
                //display many 
            }

        }
        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrow {amount}. New balance: {Balance}");
            }

        }

        public bool ValidatePin(string pin)
        {
            if (!string.IsNullOrEmpty(pin) && pin.All(char.IsDigit) && pin.Length == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
