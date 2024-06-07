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
       

        public required string Isbn { get; set; }

        public string Genre { get; set; }

    
     
        public override string GetDetails()
        {
            return $"Book details: \nTitle - {Title}, \nAuthor - {Author}," +
                $"\nPublished - {YearPublished}, \nbook's ISBN - {Isbn},\n genre - {Genre}," +
                $" \nAvailability stats - {IsBorrowed}";
          
        }
    }
}
