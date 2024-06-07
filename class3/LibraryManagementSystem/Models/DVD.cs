using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class DVD : LibraryItem
    {
   

        public decimal DurationInMinutes { get; set; }

        public required int Rating { get; set; }


     
     
        public override string GetDetails()
        {
           return 
                $"The book details: \nTitle - {Title}, \nDirected by - {Author}, " +
                $"\nProduction year - {YearPublished}, " +
                $"\nDuration - {DurationInMinutes} minutes," +
                $"\nAvailability stats - {IsBorrowed}"
         ;
        }
    }
}
