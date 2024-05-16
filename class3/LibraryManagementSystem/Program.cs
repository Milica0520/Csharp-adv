using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using System.Security.Cryptography.X509Certificates;

namespace LibraryManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ILibraryItem> listOfItems = new List<ILibraryItem>
            {
            new Book("Pride and Prejudice", "Jane Austen", 1813, 9780141439518, "Romance"),
            new Book("The Hobbit", "J.R.R. Tolkien", 1937, 9780345534835, "Fantasy"),
            new Book("The Lord of the Rings", "J.R.R. Tolkien", 1954, 9780618640157, "Fantasy"),
            new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", 1979, 9780345391803, "Science Fiction"),
            new Book("Brave New World", "Aldous Huxley", 1932, 9780060850524, "Dystopian"),
            //
            new DVD("Inception", "Christopher Nolan", 2010, 148.5m),
            new DVD("The Dark Knight", "Christopher Nolan", 2008, 152.0m),
            new DVD("Pulp Fiction", "Quentin Tarantino", 1994, 154.0m),
            new DVD("The Shawshank Redemption", "Frank Darabont", 1994, 142.0m),
            new DVD("Fight Club", "David Fincher", 1999, 139.0m),
            //
            new Comic("Spider-Man: The Amazing Spider-Man", "Stan Lee", 1963),
            new Comic("Batman: The Dark Knight Returns", "Frank Miller", 1986),
            new Comic("Superman: The Death of Superman", "Dan Jurgens", 1992),
            new Comic("X-Men: The Dark Phoenix Saga", "Chris Claremont", 1980),
            new Comic("Watchmen", "Alan Moore", 1986),
            //
            new Magazine("National Geographic", "National Geographic Partners", 2023, 5),
            new Magazine("Time", "Time USA, LLC", 2023, 20),
            new Magazine("The Economist", "The Economist Newspaper Limited", 2023, 9839),
            new Magazine("Vogue", "Condé Nast", 2023, 653),
            new Magazine("Rolling Stone", "Penske Media Corporation", 2023, 1346)

            };
            Library CityLibrery = new(listOfItems);
         
          
            Console.WriteLine("Welcome to Library Menagmnet sistem.");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a library item");
            Console.WriteLine("2. Remove a library item");
            Console.WriteLine("3. Borrow a library item");
            Console.WriteLine("4. Return a library item");
            Console.WriteLine("5. Display details of a library item");
            Console.WriteLine("6. Exit");
            //
            Console.Write("Enter your choice: ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Choose Type of Item to add: (Book, Magazine, Comic, DVD)");
                    string typeInp = Console.ReadLine();
                    //
                    if (typeInp.ToLower() == "book")
                    {
                        Console.WriteLine("Enter title of the book:");
                        string titleInp = Console.ReadLine();
                        Console.WriteLine("Enter author of the book:");
                        string authorInp = Console.ReadLine();
                        Console.WriteLine("Enter publishing year of the book:");
                        int yearInp = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter ISBN (13 dogits) number of the book:");
                        long isbnInp = long.Parse(Console.ReadLine());
                        Console.WriteLine("Enter genre of the book:");
                        string genreInp = Console.ReadLine();

                        Book newItem = new(titleInp, authorInp, yearInp, isbnInp, genreInp);

                        CityLibrery.AddItem(newItem);
                        
                      
                    }

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                default:
                    Console.WriteLine("Input error. Enter a number(1-6).");
                    break;

            }

            

        }





    }
      
    
}
