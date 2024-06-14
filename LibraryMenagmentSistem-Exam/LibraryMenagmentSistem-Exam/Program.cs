using LibraryMenagmentSistem_Exam.Models;
using System.Transactions;

namespace LibraryMenagmentSistem_Exam
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
        {
            new Book
            {
                Title = "Zapisi iz podzemlja",
                Author = "Fjodor Dostojevski",
                ISBN = "364758693213"
            },
            new Book
            {
                Title = "Dervis i smrt",
                Author = "Mesa Selimovic",
                ISBN = "9780140449136"
            },
            new Book
            {
                Title = "Braca Karamazovi",
                Author = "Fjodor Dostojevski",
                ISBN = "9780140449242"
            },
            };
            List<User> users = new List<User>
        {
            new User
            {
                UserName = "Marija",
                Email = "maki@gmail.com"
            },
            new User
            {
                UserName = "Ivan",
                Email = "ivan@gmail.com"
            },
            new User
            {
                UserName = "Ana",
                Email = "ana@gmail.com"
            }
        };

            Library library = new Library();


            library.AddBook(new Book
            {
                Title = "Zapisi iz podzemlja",
                Author = "Fjodor Dostojevski",
                ISBN = "364758693213"
            });
            library.AddBook(new Book
            {
                Title = "Dervis i smrt",
                Author = "Mesa Selimovic",
                ISBN = "9780140449136"
            });
            library.AddBook(new Book
            {
                Title = "Braca Karamazovi",
                Author = "Fjodor Dostojevski",
                ISBN = "9780140449242"
            });
            library.AddUser(new User
            {
                UserName = "Marija",
                Email = "maki@gmail.com"
            });
            library.AddUser(new User
            {
                UserName = "Ivan",
                Email = "ivan@gmail.com"
            });
            library.AddUser(new User
            {
                UserName = "Ana",
                Email = "ana@gmail.com"
            });


            Console.WriteLine("Welcome to Library Menagment Sistem.");
            Console.WriteLine("Enter your user name:");
            string nameInp = Console.ReadLine();

            User currUser = null;

            library.Start();








        }










    }
}
