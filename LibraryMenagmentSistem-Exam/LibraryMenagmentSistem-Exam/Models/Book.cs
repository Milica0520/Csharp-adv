using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibraryMenagmentSistem_Exam.Models
{
    public class Book
    {
        public required string Title {  get; set; }  
        public required string Author { get; set; }
        public required string ISBN {  get; set; }  
      
        public bool  IsAvailable { get; set; } = true;


        public string GetBookInfo()
        {
            return $"Book title: {Title}, author: {Author}, ISBN: {ISBN}, Available: {IsAvailable}";
        }

    }
}
