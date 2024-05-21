using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class DVD : LibraryItem
    {
       
        public int DurationInMinutes { get; set; }

        public required int Rating { get; set; }
     
        public override void GetDetails()//nije ispisivao isBorrowed
        {
            Console.WriteLine
                (
                $"The book details: \nTitle - {Title}, \nDirected by - {}, " +
                $"\nProduction year - {YearOfProduction}, " +
                $"\nDuration - {DurationInMinutes}," +
                $"\nAvailability stats - {IsBorrowed}"
                );
        }
    }
}
