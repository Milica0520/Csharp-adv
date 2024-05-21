using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Magazine : LibraryItem
    {
     

        public string Publisher { get; set; }//string.Empty

        public required int IssueNumber { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine($"The magazine details: \nTitle - {Title}, \nPublisher - {Publisher}, " +
               $"\nPublished - {YearPublished}, " +
               $"\nIssue number - {IssueNumber}," +
               $"\nAvailability stats - {IsBorrowed}");
        }
    }
}
