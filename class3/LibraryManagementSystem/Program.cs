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

            Library CityLibrery = new(listOfItems);

            Console.WriteLine("Welcome to Library Menagmnet sistem.");
            Console.WriteLine("Choose an option:");
           
            Console.WriteLine("1. Add a library item");
            Console.WriteLine("2. Remove a library item");
            Console.WriteLine("3. Borrow a library item");
            Console.WriteLine("4. Return a library item");
            Console.WriteLine("5. Display details of a library item");
            Console.WriteLine("6. Search item by Title: ");
            Console.WriteLine("0. Exit");
            //
            Console.Write("Enter your choice: ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
            
                case 1:
                    AddNewItem();
                    break;
                case 2:
                    RemoveLibraryItem();
                    break;
                case 3:


                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:



                    break;
                case 0:






                    break;
                default:
                    Console.WriteLine("Input error. Enter a number(1-6).");
                    break;

            }
            void AddNewItem()
            {
                Console.WriteLine("Choose Type of Item to add: (Book, Magazine, Comic, DVD)");
                string typeInp = Console.ReadLine().ToLower();

                string[] itemTypes = new string[] {"book", "magazine", "comic" , "dvd" };
                //
                foreach (string type in itemTypes) 
                {
                    if (typeInp.ToLower() == type)
                    {
                        
                        Console.WriteLine($"Enter title of the {typeInp}:");
                        string titleInp = Console.ReadLine();
                        Console.WriteLine($"Enter author of the {typeInp}:");
                        string authorInp = Console.ReadLine();
                        Console.WriteLine($"Enter publishing year of the {typeInp}:");
                        int yearInp = int.Parse(Console.ReadLine());

                        switch (typeInp)
                        {
                            case "book":
                                Console.WriteLine($"If {typeInp} have ISBN (13 dogits) Enter the number :");
                                string isbnInp = Console.ReadLine();
                                Book bookItem = new Book { Author = authorInp, Title = titleInp, Isbn = isbnInp, YearPublished = yearInp };
                                CityLibrery.AddItem(bookItem);
                                Console.WriteLine($"Item : {bookItem.GetDetails()} , added to Library");
                                break;
                            case "magazine":

                                Console.WriteLine($"If {typeInp} have IssueNumber  Enter the number :");
                                int issueNumInp = int.Parse(Console.ReadLine());
                                Magazine magazineItem = new Magazine { Author = authorInp, IssueNumber = issueNumInp, Title = typeInp };
                                CityLibrery.AddItem(magazineItem);
                                Console.WriteLine($"Item : {magazineItem.GetDetails()} , added to Library");
                                break;

                            case "comic":
                                Console.WriteLine($"If {typeInp} have Artist  Enter the Artist name :");
                                string artistInp = Console.ReadLine();
                                Comic comicItem = new Comic { Title = typeInp, Artist = artistInp, Author = authorInp};
                                CityLibrery.AddItem(comicItem);
                                Console.WriteLine($"Item : {comicItem.GetDetails()} , added to Library");
                                break;

                            case "dvd":
                                Console.WriteLine($"If {typeInp} have Rating  Enter the Rating :");
                                int ratingInp = int.Parse(Console.ReadLine());
                                DVD dvdItem = new DVD { Author = authorInp, Title = titleInp, Rating = ratingInp };
                                CityLibrery.AddItem(dvdItem);
                                Console.WriteLine($"Item : {dvdItem.GetDetails()} , added to Library");
                                break;
                            default:
                                Console.WriteLine($"Error...Item is not added to Library.Try again ");
                                break;  
                        }
                    }
                }
            }

            void RemoveLibraryItem()
            {
                Console.WriteLine("Enter Type of Item you want to remove : ");
                string searchedItem = (Console.ReadLine().ToLower());
                List<ILibraryItem> typeOfItems = listOfItems
                    .Where(item => item.GetType() == typeof(Book))
                    .ToList();

                foreach (ILibraryItem item in typeOfItems)
                {
                    Console.WriteLine($"{item.GetDetails()}");
                }
                Console.WriteLine("Enter title of item you want to remove(Book, Magazine, Comic, DVD): ");
                string itemTitleToRemove = (Console.ReadLine()).ToLower();


                foreach (ILibraryItem item in typeOfItems)
                {
                    if (item.Title == itemTitleToRemove)
                    {
                        CityLibrery.RemoveItem(item);

                    }
                    Console.WriteLine($"{item.Title} has been removed");
                }
            }
            //trebam napraviti funkciju za provjeru inputa

        }




    }


}
