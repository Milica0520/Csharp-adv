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
            Book searchedBook = _books
                              .Where(item => item.Title.Contains(word)
                              || item.Author.Contains(word)
                              || item.ISBN.Contains(word)
                              )
                              .FirstOrDefault();

            return searchedBook;
        }
     

        public void BorrowBook(Book book, User user)
        {
            book.IsAvailable = false;
            user.CheckedOutBooks.Add(book);
            Transaction borrowTransaction = new Transaction() { Book = book, User = user, Date = DateTime.Now };
            _transactions.Add(borrowTransaction);
            DateTime dateToReturn = borrowTransaction.Date.AddDays(14);
            Console.WriteLine($"You borrowed book.Please return the book by {dateToReturn.ToString()}  ");
        }
        public void ReturnBook(Book book, User user)
        {
            book.IsAvailable = true;
            user.CheckedOutBooks.Add(book);
            Transaction returnTransaction = new Transaction() { Book = book, User = user, Date = DateTime.Now };
            _transactions.Add(returnTransaction);
        }

        public User LogIn(string userNameInp)
        {
            User currUser = _users
                  .Where(user => user.UserName.ToLower() == userNameInp.ToLower())
                  .FirstOrDefault();
            return currUser;

        }


        public void Start(User currUser)
        {

            bool exit = false;
            do
            {
                
                Console.WriteLine("Chose an option: ");
                Console.WriteLine("1. Search Book.");
                Console.WriteLine("2. Borrow Book.");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("0. Exit");

                string stringInp = Console.ReadLine();
                int choseNum ;
                bool isParsed = int.TryParse(stringInp, out choseNum);

                if (!isParsed)
                {
                    Console.WriteLine("Incorrect input. Try again.");
                }
                else
                {
                switch (choseNum)
                {
                    case 0:
                        exit = true;
                        Console.WriteLine("Thank you for using the Library Menagment Sistem. Goodbay!");
                        break;
                    case 1:
                        Console.WriteLine("Enter kayword to search for a book: ");
                        string wordInp = Console.ReadLine();


                         Book searchedBook = this.FindBook(wordInp);
                            Console.WriteLine($"Book found. Book info: ");
                            searchedBook.GetBookInfo();

                        break;
                    case 2:
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
                                Console.WriteLine($"{availableBook[i].Title} borrowed by {currUser}");
                            }
                        }
                        break;

                    case 3:


                        int index = 0;
                        foreach (Book item in currUser.CheckedOutBooks)
                        {
                            Console.WriteLine($"{index++} : {item.GetBookInfo()}");
                        }
                        Console.WriteLine("Enter index of a book you want to return");
                        int indexInpR = int.Parse(Console.ReadLine());

                        for (int i = 0 ; i < currUser.CheckedOutBooks.Count ; i++)
                        {
                            if (i == indexInpR)
                            {
                                this.ReturnBook(currUser.CheckedOutBooks[i], currUser);
                                Console.WriteLine($"{currUser.CheckedOutBooks[i].Title} returned.");
                            }
                        }

                        break;
                    default:
                        Console.WriteLine("Unknown input. Please try again");
                        break;
                }
                }

            } while (exit == false);


        }




    }
}
