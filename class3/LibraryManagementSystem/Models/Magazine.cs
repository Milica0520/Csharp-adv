using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Magazine : LibraryItem
    {
        public string Title { get; set; }

        public string Publisher { get; set; }

        public int YearPublished { get; set; }

        public bool IsBorrowed { get; set; } = false;

        public int IssueNumber { get; set; }



        public Magazine(string title,  string publisher, int yearPublished, int issueNumber)
        {
            Title = title;
            Publisher = publisher;
            YearPublished = yearPublished;
            IssueNumber = issueNumber;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"The book details: \nTitle - {Title}, \nPublisher - {Publisher}, " +
               $"\nPublished - {YearPublished}, " +
               $"\nIssue number - {IssueNumber}," +
               $"\nAvailability stats - {IsBorrowed}");
        }
    }
}
