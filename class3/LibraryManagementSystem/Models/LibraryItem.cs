using LibraryManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public abstract class LibraryItem : ILibraryItem
    {

        public required string Title { get; set; }
        public required string Author { get; set; }
        public int? YearPublished { get; set; }
        public bool IsBorrowed { get; private set; }

       

        public void BorrowItem()
        {
            IsBorrowed = true;
        }

        public void ReturnItem()
        {
            IsBorrowed = false;
        }

        public abstract string GetDetails();
    }


}

