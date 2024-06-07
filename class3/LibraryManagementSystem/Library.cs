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

        public void AddNewItem(ILibraryItem inputItem) 
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

        public void DisplayItemDetails()
        {
            foreach (var item in LibraryItems)
            {
                Console.WriteLine(item.GetDetails());
            }
        }
    }
}
