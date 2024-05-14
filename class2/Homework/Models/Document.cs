using Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Models
{
    public abstract class Document : ISearchable
    {

        public List<string> Words { get; set; }
        public string Word { get ; set ; }

        protected Document()
        {
            Words = new List<string>();
        }
        public abstract void Search(string word);
      
    }
}
