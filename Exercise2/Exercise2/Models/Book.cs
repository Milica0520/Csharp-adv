using Exercise2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Models
{
    public class Book : IBook
    {
        public int Id { get ; set ; }
        public string Title { get ; set ; }
        public string Author { get; set ; }
        public int Year { get ; set ; }

        public string GetBookInfo()
        {
            return $"Id: {Id}, Title: {Title}, Author: {Author}, Year: {Year}";
        }
    }
}
