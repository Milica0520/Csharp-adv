using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Comic : LibraryItem
    {
        public string Title { get; set; }

        public string Artist { get; set; }

        public int YearPublished { get; set; }

        public bool IsBorrowed { get; set; }= false;

        public Comic(string title, string artist, int yearPublished)
        {
            Title = title;
            Artist = artist;
            YearPublished = yearPublished;
               
        }
        public override void GetDetails()
        {
            Console.WriteLine
                (
                $"The book details: \nTitle - {Title}," +
                $"\nArtist - {Artist}, " +
                $"\nPublished - {YearPublished}, " +
                $"\nAvailability stats - {IsBorrowed}"
                );
        }
    }
}
