using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using System.Security.Cryptography.X509Certificates;

namespace LibraryManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {

           // 
            List<ILibraryItem> listOfItems = new List<ILibraryItem>
            {
                new Comic
        {
            Title = "The Amazing Spiderman",
            Author = "Stan Lee",
            Artist = "Steve Ditko",
            YearPublished = 1963
        },

            new Book
            {
                Title = "The Catcher in the Rye",
                Author = "J.D. Salinger",
                Isbn = "978-3-16-148410-0",
                YearPublished = 1951
            },
           new Book
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Isbn = "978-3-16-148410-1",
                YearPublished = 1925
            },

           new DVD
            {
                Title = "The Godfather",
                Author = "Francis Ford Coppola",
                DurationInMinutes = 175,
                YearPublished = 1972,
                Rating = 7
            },

        };


            Library CityLibrery = new();
        
          
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
                        string isbnInp = Console.ReadLine();
                        Console.WriteLine("Enter genre of the book:");
                        string genreInp = Console.ReadLine();

                       
                        Book newItem = new Book { Author = authorInp, Title = titleInp, Isbn = isbnInp, YearPublished = yearInp };

                        CityLibrery.AddNewItem(newItem);


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
        public void AddNewItem()
        {
        
        }





    }
      
    
}
