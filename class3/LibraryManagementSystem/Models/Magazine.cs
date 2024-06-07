using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Magazine : LibraryItem
    {

      

        public string Publisher { get; set; }

        public required int IssueNumber { get; set; }


        public override string GetDetails()
        {
            return 
                $"Magazine details: \nTitle - {Title}," +
                $" \nAuthor - {Author}, " +
                $" \nPublisher - {Publisher}, " +
                $"\nPublished - {YearPublished}, " +
                $"\nIssue number - {IssueNumber}," +
                $"\nAvailability stats - {IsBorrowed}";
        }
    }
}
