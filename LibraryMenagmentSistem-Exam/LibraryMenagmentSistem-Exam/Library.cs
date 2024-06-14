using LibraryMenagmentSistem_Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenagmentSistem_Exam
{
    public class Library
    {
        private List<Book> _books = new List<Book>();

        private List<User> _users = new List<User>();

        private List<Transaction> _transactions = new List<Transaction>();


        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public Book FindBook(string word)
        {
            Book book = null;
            if (string.IsNullOrEmpty(word) == false)
            {
                book = _books
           .Where(
                    item => item.Title == word
                 || item.Author == word
                 || item.ISBN == word)
           .FirstOrDefault();
                Console.WriteLine($"Book found.{book.Title}{book.Author}{book.ISBN}");
            }
            else
            {
                Console.WriteLine("Your word not found.");
            }
            return book;

        }

        public void BorrowBook(Book book, User user)
        {
            book.IsAvailable = true;
            user.CheckedOutBooks.Add(book);
            Transaction borrowTransaction = new Transaction() { Book = book, User = user, Date = DateTime.Now };
            _transactions.Add(borrowTransaction);
            DateTime dateToReturn = borrowTransaction.Date.AddDays(14);
            Console.WriteLine($"You borrowed book.Please return the book by {dateToReturn.ToString()}  ");
        }
        public void ReturnBook(Book book, User user)
        {
            book.IsAvailable = false;
            user.CheckedOutBooks.Add(book);
            Transaction returnTransaction = new Transaction() { Book = book, User = user, Date = DateTime.Now };
            _transactions.Add(returnTransaction);
        }





        public void Start()
        {

            bool exit = false;
            do
            {
                
                Console.WriteLine("Chose an option: ");
                Console.WriteLine("1. Search Book.");
                Console.WriteLine("2. Borrow Book.");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("0. Exit");
                int userInp = int.Parse(Console.ReadLine());

                switch (userInp)
                {
                    case 0:
                        exit = true;
                        Console.WriteLine("Thank you for using the Library Menagment Sistem. Goodbay!");
                        break;
                    case 1:
                        Console.WriteLine("Enter kayword to search for a book: ");
                        string wordInp = Console.ReadLine();

                        if (wordInp != null)
                        {
                           Book foundedBook = this.FindBook(wordInp);
                           Console.WriteLine($"{foundedBook.GetBookInfo}");
                        }else
                        {
                            Console.WriteLine($"Book with kayword  \"{wordInp}\" not found.");
                        }
                        break;
                    case 2:
                        
                        if (string.IsNullOrEmpty(nameInp) == false)
                        {
                             currUser = _users
                                .Where(user => (user.UserName).ToLower() == nameInp.ToLower())
                                .FirstOrDefault();
                            Console.WriteLine($"User with user name {currUser.UserName} found");
                        }else
                        {
                            Console.WriteLine($"User with user name {nameInp} not found");
                            break;
                        }

                        Console.WriteLine("Available books:");  
                        List<Book> availableBook = _books
                             .Where(book => book.IsAvailable == true)
                             .ToList();
                        for (int i = 0; i < availableBook.Count; i++)
                        {
                            Console.WriteLine($"{i}. {availableBook[i].GetBookInfo()}");

                        }

                        Console.WriteLine("Enter index of a book you want to borrow");
                        int indexInp = int.Parse(Console.ReadLine());

                        for (int i = 0; i < availableBook.Count; i++)
                        {
                            if(i == indexInp)
                            {
                                this.BorrowBook(availableBook[i],currUser);
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter your user name:");
                        string nameInp1 = Console.ReadLine();






                        break;
                    default:
                        Console.WriteLine("Unknown input. Please try again");
                        break;
                }


            } while (exit == false);


        }




    }
}
