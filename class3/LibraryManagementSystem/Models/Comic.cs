using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Comic : LibraryItem
    {
  

        public required string Artist { get; set; }

        public override string GetDetails()
        {
           return 
                $"Comic details: \nTitle - {Title}," +
                $"\nArtist - {Artist}, " +
                $"\nAuthor - {Author}, " +
                $"\nPublished - {YearPublished}, " +
                $"\nAvailability stats - {IsBorrowed}"
                ;
        }
    }
}
