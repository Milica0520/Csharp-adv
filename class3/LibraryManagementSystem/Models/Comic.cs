using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Comic : LibraryItem
    {
       

        public string Artist { get; set; }//required-samo je ovo stavio

      
        public override void GetDetails()
        {
            Console.WriteLine
                (
                $"The comic details: \nTitle - {Title}," +
                $"\nArtist - {Artist}, " +
                $"\nPublished - {YearPublished}, " +
                $"\nAvailability stats - {IsBorrowed}"
                );
        }
    }
}
