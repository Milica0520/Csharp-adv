using LibraryManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Library 
    {

        private readonly List<ILibraryItem> _libraryItems = new();

        private readonly List<User> _users = new(); 



        public Library(List<ILibraryItem> libraryItems, List<User> users) {
        
            _libraryItems = libraryItems;
            _users = users;
        }


        public void AddItem(ILibraryItem inputItem) 
        {
            _libraryItems.Add(inputItem);
        }

        public void RemoveItem(ILibraryItem inputItem)
        {
            _libraryItems.Remove(inputItem);    
        }

        public void BorrowCurrItem(ILibraryItem inputItem)
        {
            inputItem.BorrowItem();

        }

        public void ReturnCurrItem(ILibraryItem inputItem)
        {
            inputItem.ReturnItem();
        }
        public ILibraryItem SearchItem(string title)
        {
            ILibraryItem libraryItem = null;
            foreach (ILibraryItem item in _libraryItems)
            {
                if(item.Title == title )
                {
                    libraryItem = item;
                }
            }

            return libraryItem;

        }

        public void DisplayItemDetails()
        {
            foreach (var item in _libraryItems)
            {
                Console.WriteLine(item.GetDetails());
            }
        }

     
    }
}
