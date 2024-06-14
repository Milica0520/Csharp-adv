using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interfaces
{
    public interface ILibraryItem
    {

        string Title { get; }
        bool IsBorrowed { get; }
        public void BorrowItem();
        public void ReturnItem();
        public string GetDetails();
    }
}
