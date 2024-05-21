using LibraryManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Library //ne bi trebalo da bude u folderu models
    {
        private List<ILibraryItem> LibraryItems { get; set; }//_items konvencija za privatno polje
      //  private readonly List<ILibraryItem> _libraryItems = new();ovo je fild , readonly ????
     

        public void AddItem(ILibraryItem inputItem) {
            LibraryItems.Add(inputItem);
        }
        public void RemoveItem(ILibraryItem inputItem)
        {
           
            LibraryItems.Remove(inputItem);
           
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
                item.GetDetails();
            }

        }
    }
}
