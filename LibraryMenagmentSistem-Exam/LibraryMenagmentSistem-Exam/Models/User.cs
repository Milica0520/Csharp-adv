using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenagmentSistem_Exam.Models
{
    public class User
    {

        public List<Book> CheckedOutBooks = new List<Book>();
        public required string UserName { get; set; }    
        public required string Email { get; set; }

    }
}
