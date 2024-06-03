using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.Models
{
    public abstract class Account
    {
       // private string _account;
        public string AccountNumber
        {
            get;set;
        }
        public string Pin {
            get; set;
        }
        public double Balance { get; set; }

        public Account(string accountNumber, string pin, double balance)
        {
            AccountNumber = accountNumber;
            Pin = pin;
            Balance = balance;
        }

    }
}
