using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.Models
{
    public class AccountsMenager<T> where T : Account
    {
        public List<T> Accounts { get; set; } = new List<T>();

        public void Login(string pinInp, string accountNumInp)
        {
           T account = Accounts.Where(account => account.Pin == pinInp && account.AccountNumber == accountNumInp).FirstOrDefault();

            if (account == null)
            {
                Console.WriteLine($"Pin code or Account number are not correct.Try again.");
                return;
            }else
            {
                Console.WriteLine($"Logged in as {accountNumInp}");
            }
        }
    }
}
