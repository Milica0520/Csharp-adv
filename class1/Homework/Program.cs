using Homework.Models;

namespace Homework
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("Book1", "Author1" , 2010),
                  new Book("Book2", "Author2" , 2005),
                    new Book("Book3", "Author3" , 2018),
                      new Book("Book4", "Author4" , 2020),
                        new Book("Book5", "Author5" , 2001),
            };


            List<Book> selestedAuthor = books
                .Where(book => book.Author == "Author1")
                .ToList();

            List<Book> booksByYear = books
                .OrderBy(book => book.Year)
                .ToList();


            List<string> bookTitles = books
                .Select(book => book.Title)
                .ToList();

          
            Console.WriteLine($"{selestedAuthor[0].Title} by {selestedAuthor[0].Author}");

            Console.WriteLine("Books by publiching year are :");
            foreach (Book book in booksByYear)
            {
                Console.WriteLine($"Title - {book.Title}, publishing year - {book.Year}");
            }
            Console.WriteLine("Books titles are :");
            foreach (string title in bookTitles)
            {
                Console.WriteLine($"{title}");
            }

            
        }
    }
}
