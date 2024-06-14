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
               new DVD
            {
                Title = "Brazil",
                Author = "Terry Gilliam",
                DurationInMinutes = 132,
                YearPublished = 1985,
                Rating = 10
            },

        };

            List<User> users = new List<User>
{
    new User { UserName = "Alice", CardNumber = "1234-5678" },
    new User { UserName = "Bob", CardNumber = "2345-6789" },
    new User { UserName = "Charlie", CardNumber = "3456-7890" },
    new User { UserName = "Diana", CardNumber = "4567-8901" },
    new User { UserName = "Eve", CardNumber = "5678-9012" }
};

            Library CityLibrery = new(listOfItems, users);

            //
            User user = new() { UserName = "Marija", CardNumber = "87643" };

            Console.WriteLine("Log in to LibraryManagementSystem");
            Console.WriteLine("Enter your UserName: ");
            string userNameInp = Console.ReadLine();
            Console.WriteLine("Enter your CardNumber:");
            string cardNumInp = Console.ReadLine();


            bool userFound = false;
              
            foreach (User item in users)
            {
                if (int.TryParse(cardNumInp, out var cardNum) && item.UserName == userNameInp)
                {
                    Console.WriteLine("You are loged in.");
                    userFound = true;
                   
                    break;
                }
            }
            if (!userFound)
            {
                Console.WriteLine($"No user with user name {userNameInp} and card number {cardNumInp}");
                return;
            }






            bool exit = false;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to Library Menagmnet sistem.");
                Console.WriteLine("Choose an option:");
                Console.WriteLine();
                Console.WriteLine("1. Add a library item");
                Console.WriteLine("2. Remove a library item");
                Console.WriteLine("3. Borrow a library item");
                Console.WriteLine("4. Return a library item");
                Console.WriteLine("5. Search item by Title and display ditails ");
                Console.WriteLine("6. List All Items ");
                Console.WriteLine("0. Exit");

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
                        BorrowLibraryItem();
                        break;
                    case 4:
                        ReturnLibraryItem();
                        break;
                    case 5:
                        SerachCurrItem();
                        break;
                    case 6:
                        CityLibrery.DisplayItemDetails();
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Input error. Enter a number(1-6).");
                        break;

                }
                void AddNewItem()
                {
                    Console.WriteLine("Choose Type of Item to add: (Book, Magazine, Comic, DVD)");
                    string typeInp = Console.ReadLine().ToLower();

                    string[] itemTypes = new string[] { "book", "magazine", "comic", "dvd" };
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
                                    Comic comicItem = new Comic { Title = typeInp, Artist = artistInp, Author = authorInp };
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
                    Console.WriteLine("Enter title of item you want to remove: ");
                    string itemTitleToRemove = Console.ReadLine();
                    ILibraryItem itemToRemove = CityLibrery.SearchItem(itemTitleToRemove);
                    if (itemToRemove != null)
                    {
                        CityLibrery.RemoveItem(itemToRemove);
                        Console.WriteLine("Item removed");
                    }
                    else
                    {
                        Console.WriteLine("Error...");
                    }
                }
                //trebam napraviti funkciju za provjeru inputa
                void SerachCurrItem()
                {
                    Console.WriteLine("Enter title: ");
                    string titleItemInp = Console.ReadLine();
                    ILibraryItem searchedItem = CityLibrery.SearchItem(titleItemInp);

                    if (searchedItem != null)
                    {
                        Console.WriteLine($"Item found. Item info : {searchedItem.GetDetails()}");
                    }
                    else
                    {
                        Console.WriteLine("Item not found.");
                    }
                }
                void BorrowLibraryItem()
                {
                    Console.WriteLine($"Enter title of item you want to borrow: ");
                    string titleToBorrow = Console.ReadLine();

                    ILibraryItem itemToBorrow = CityLibrery.SearchItem(titleToBorrow);

                    if (itemToBorrow.IsBorrowed == true)
                    {
                        Console.WriteLine("Item is not current available.");
                    }
                    else
                    {
                        CityLibrery.BorrowCurrItem(itemToBorrow);
                        Console.WriteLine("Item borrowed.");
                    }



                }
                void ReturnLibraryItem()
                {
                    Console.WriteLine("Enter title of the item you want to return: ");
                    string titleToReturn = Console.ReadLine();

                    ILibraryItem itemToReturn = CityLibrery.SearchItem(titleToReturn);

                    if (itemToReturn.IsBorrowed == true)
                    {
                        CityLibrery.BorrowCurrItem(itemToReturn);
                        Console.WriteLine("Item returned.");

                    }
                    else
                    {
                        Console.WriteLine("Error.!ReturnLibraryItem...");
                    }


                }
            } while (exit == false);
        }
    }
}



