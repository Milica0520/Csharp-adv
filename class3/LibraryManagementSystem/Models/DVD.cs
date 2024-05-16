using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class DVD : LibraryItem
    {
        public string Title { get; set; }

        public string Director { get; set; }

        public int YearOfProduction { get; set; }

        public bool IsBorrowed { get; set; }= false;

        public decimal Duration { get; set; }

        public int Rating { get; set; }
        public DVD(string titele, string director, int yearOfProduction, decimal duration)
        {
            Title = titele;
            Director = director;
            YearOfProduction = yearOfProduction;
            Duration = duration;
           
        }
        public override void GetDetails()
        {
            Console.WriteLine
                (
                $"The book details: \nTitle - {Title}, \nDirected by - {Director}, " +
                $"\nProduction year - {YearOfProduction}, " +
                $"\nDuration - {Duration}," +
                $"\nAvailability stats - {IsBorrowed}"
                );
        }
    }
}
