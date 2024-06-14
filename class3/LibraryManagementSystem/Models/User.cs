using LibraryManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class User
    {
        
        private  List<ILibraryItem>? _borrowedItems = new();

        public string UserName { get; set; }    
        public string CardNumber { get; set; }  



    }
}
