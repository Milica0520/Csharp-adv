using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.Interfaces
{
    public interface IAccount
    {
        void Deposit(double amount);//to deposit funds into an accout
        void Withdraw(double amount);//to withdraw funds from an account
        bool ValidatePin(string pin);//to validate the entered PIN

    }
}
