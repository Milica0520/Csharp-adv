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
        List<ILibraryItem> LibraryItems { get; set; }

        public Library(List<ILibraryItem> libraryItems)
        {
            LibraryItems = libraryItems;    
        }

        public void AddItem(ILibraryItem inputItem) {
            LibraryItems.Add(inputItem);
        }
        public void RemoveItem(ILibraryItem inputItem)
        {
            foreach (ILibraryItem item in LibraryItems)
            {
                if(inputItem == item)
                {
                    LibraryItems.Remove(inputItem);
                }
                else
                {
                    Console.WriteLine("No such item in Library to remove.");
                }
            }
           
        }
        public void BorrowItem()
        {

        }
        public void ReturnItem()
        {

        }
        public void DisplayItemDetails()
        {
            
        }
    }
}
