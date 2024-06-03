using ATM_App.Models;

namespace ATM_App
{
    public class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount user1 = new SavingsAccount("836294","11111", 53628.76);
            SavingsAccount user2 = new SavingsAccount("048638", "22222", 628.76);

            CheckingAccount user3 = new CheckingAccount("098765", "33333", 250.59);
            CheckingAccount user4 = new CheckingAccount("094834", "44444", 650.59);

            AccountsMenager<SavingsAccount> savingAccounts = new AccountsMenager<SavingsAccount>();
            AccountsMenager<CheckingAccount> checkingAccounts = new AccountsMenager<CheckingAccount>();


            savingAccounts.Accounts.Add(user1);
            savingAccounts.Accounts.Add(user2);
            checkingAccounts.Accounts.Add(user3);
            checkingAccounts.Accounts.Add(user4);

            Console.WriteLine("Welcome to the ATM.");
            Console.WriteLine("Enter account number: ");
            string accountInp = Console.ReadLine();
           
            Console.WriteLine("Enter PIN: ");
            string pinInp = Console.ReadLine();


            savingAccounts.Login(accountInp, pinInp);







        }
      
    }
}
