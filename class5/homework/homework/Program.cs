using homework.Helpers;
using homework.Models;
using System.Security.Cryptography.X509Certificates;

namespace homework
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User(1, "Sava", 22),
                new User(2, "Tamara", 25),
                new User(3, "Dordje", 28),
                new User(4, "Goran", 27),
                new User(5, "Dusan", 30),
                new User(6, "Almir", 29),
                new User(7, "Goran", 23),
                new User(8, "Stefan",23 ),
            };
            UserDatabase.Users = users;

            Console.WriteLine("Search user by : ");
            Console.WriteLine("1.Id");
            Console.WriteLine("2.Name");
            Console.WriteLine("3.Age ");
            int userInput = int.Parse(Console.ReadLine());  

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Enter Id:");
                    int idInput = int.Parse(Console.ReadLine());
                    UserDatabase.GetUserById(idInput);
                    break;
                case 2:
                    Console.WriteLine("Enter Name:");
                    string nameInput = Console.ReadLine().ToLower();
                    UserDatabase.GetUserByName(nameInput);
                    break;
                case 3:
                    Console.WriteLine("Enter Age:");
                    int ageInput =int.Parse(Console.ReadLine());
                    UserDatabase.GetUserByAge(ageInput);
                    break;
                default:
                    Console.WriteLine("Input unknown.Try again.");
                    break;
            }
            

        }
    }
}
