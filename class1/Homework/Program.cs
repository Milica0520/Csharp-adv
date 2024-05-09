using Homework.Models;


namespace Homework
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book> { 
                new Book("Book1","Author1", 2005),
                new Book("Book2", "Author2", 2010),
                new Book("Book3", "Author3", 2018),
                new Book("Book4", "Author4", 2001)
               };

            List<Book> author1 = books
                .Where(book => book.Author == "Author1")
                .ToList();

            List<Book> sortedByYear = books.OrderBy(book => book.Year).ToList();

        }
    }
}
