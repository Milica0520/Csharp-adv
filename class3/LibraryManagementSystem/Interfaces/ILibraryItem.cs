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
        public string Title {
            get; set;
        }  

        pub
        public void BorrowItem();
        public void ReturnItem();
        public void GetDetails();//string
    }
}
