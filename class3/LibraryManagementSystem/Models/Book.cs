using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Book : LibraryItem
    {

       



        public required long Isbn { get; set; }

        public string Genre { get; set; }

        public Book(): base()
        {

        }
     
        public override void GetDetails()
        {
            Console.WriteLine
                (
                $"The book details: \nTitle - {Title}, \nAuthor - {Author}, " +
                $"\nPublished - {YearPublished}, " +
                $"\nbook's ISBN - {Isbn},\n genre - {Genre}," +
                $"\nAvailability stats - {IsBorrowed}"
                );
        }
    }
}
