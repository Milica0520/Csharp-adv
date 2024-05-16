using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Book : LibraryItem
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int YearPublished { get; set; }

        public bool IsBorrowed { get; set; }=false;

        public long ISBN { get; set; }

        public string Genre { get; set; }

        public Book(string title, string author, int yearPublished,  long isbn, string genre)
        {
            Title = title;
            Author = author;
            YearPublished = yearPublished;
            Genre = genre;
            ISBN = isbn;
           
            

        }


        public override void GetDetails()
        {
            Console.WriteLine
                (
                $"The book details: \nTitle - {Title}, \nAuthor - {Author}, " +
                $"\nPublished - {YearPublished}, " +
                $"\nbook's ISBN - {ISBN},\n genre - {Genre}," +
                $"\nAvailability stats - {IsBorrowed}"
                );
        }
    }
}
